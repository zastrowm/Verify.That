using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace VerifiedAssertions
{
  /// <summary>
  ///  Helper class to get an instance of <see cref="ElementComparer{T}"/> from a <see cref="Type"/> object.
  /// </summary>
  internal class ElementComparer
  {
    public static readonly MethodInfo CompareGenericMethodInfo = GetNonGenericMethod();

    private static MethodInfo GetNonGenericMethod()
    {
      return typeof(ElementComparer).GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
                                              .Single(m => m.Name == nameof(CompareGeneric))!;
    }

    public static bool Compare(Context context, Type elementType, IEnumerable left, IEnumerable right)
    {
      var method = CompareGenericMethodInfo.MakeGenericMethod(elementType);
      return (bool)method.Invoke(null, new object[] { context, left, right })!;
    }

    [Description("Reflection")]
    private static bool CompareGeneric<T>(Context context, IEnumerable left, IEnumerable right)
    {
      return new ElementComparer<T>(context, null)
        .CompareEachElement((IEnumerable<T>)left, (IEnumerable<T>)right);
    }
  }

  /// <summary>
  ///   Helper class to compare two instances of <see cref="IEnumerable{T}"/>.
  /// </summary>
  internal class ElementComparer<T>
  {
    private readonly Context _context;
    private readonly IEqualityComparer<T> _comparer;
    private readonly bool _isUsingDefaultComparer;

    public ElementComparer(Context context, IEqualityComparer<T>? comparer)
    {
      _context = context;
      _comparer = comparer ?? EqualityComparer<T>.Default;

      if (comparer == null)
      {
        _isUsingDefaultComparer = true;
      }
    }

    public bool CompareEachElement(IEnumerable<T> sequenceActual,
                                   IEnumerable<T> sequenceExpected)
    {
      int index = 0;

      var collectionCountInfo = new CollectionCount(sequenceExpected, sequenceActual);

      using (var enumeratorActual = sequenceActual.GetEnumerator())
      using (var enumeratorExpected = sequenceExpected.GetEnumerator())
      {
        do
        {
          bool didActualMove = enumeratorActual.MoveNext();
          bool didRightMove = enumeratorExpected.MoveNext();

          if (didActualMove != didRightMove)
          {
            _context.Writer.WriteLine($"Sequence has different length than expected");

            if (collectionCountInfo.HasBothCounts)
            {
              using (_context.Writer.Indent())
              {
                _context.Writer.WriteLine($"Expected count = {collectionCountInfo.CountExpected}");
                _context.Writer.WriteLine($"Actual count   = {collectionCountInfo.CountActual}");
                _context.Writer.WriteLine();

                WritePrecedingElementsWereEqual(index);
              }
            }
            else if (didActualMove)
            {
              if (index == 0)
              {
                _context.Writer.WriteLine($"Actual sequence was non-empty, expected sequence was empty.");
              }
              else
              {
                _context.Writer.WriteLine($"After {index} elements, expected sequence stopped");
              }
            }
            else
            {
              if (index == 0)
              {
                _context.Writer.WriteLine($"Expected sequence was non-empty, actual sequence was empty.");
              }
              else
              {
                _context.Writer.WriteLine($"After {index} elements, actual sequence stopped");
              }
            }
          }

          if (!didActualMove)
          {
            break;
          }

          if (!_comparer.Equals(enumeratorActual.Current, enumeratorExpected.Current))
          {
            WriteAssertionFailedForIndex(index, enumeratorExpected, enumeratorActual, collectionCountInfo);
            return false;
          }

          index++;
        } while (true);
      }

      return true;
    }

    private void WriteAssertionFailedForIndex(int index, IEnumerator<T> enumerableExpected, IEnumerator<T> valueActual, CollectionCount collectionCount)
    {
      var writer = _context.Writer;

      using (writer.Indent())
      {
        writer.WriteLine($"Sequence differs at index {index}");

        using (writer.Indent())
        {
          writer.WriteLine($"Expected: == {_context.Wrap(enumerableExpected.Current)}");
          writer.WriteLine($"Actual:      {_context.Wrap(valueActual.Current)}");
        }

        WriteComparerInfo(writer);
      }

      writer.WriteLine();

      WritePrecedingElementsWereEqual(index);

      if (collectionCount.HasBothCounts)
      {
        if (collectionCount.CountExpected != collectionCount.CountActual)
        {
          writer.WriteNoteLine($"Expected length is {collectionCount.CountExpected}, actual length is {collectionCount.CountActual}");
        }
        else
        {
          writer.WriteNoteLine($"Expected length and actual length is {collectionCount.CountExpected}");
        }
      }
    }

    private void WritePrecedingElementsWereEqual(int index)
    {
      if (index > 1)
      {
        _context.Writer.WriteNoteLine($"Elements at indices 0 - {index-1} were equal");
      }
      else if (index > 0)
      {
        _context.Writer.WriteNoteLine($"Element at index 0 was equal");
      }
    }

    private void WriteComparerInfo(Writer writer)
    {
      if (_isUsingDefaultComparer)
      {
        writer.WriteLine($"(using default comparer)");
      }
      else
      {
        writer.WriteLine($"(using custom comparer)");
      }
    }

    private struct CollectionCount
    {
      public CollectionCount(IEnumerable<T> expected, IEnumerable<T> actual)
      {
        CountExpected = GetCountOf(expected);
        CountActual = GetCountOf(actual);

        HasBothCounts = CountExpected != null && CountActual != null;

        int? GetCountOf(IEnumerable<T> sequence)
        {
          if (sequence is ICollection collection)
          {
            return collection.Count;
          }
          else if (sequence is IReadOnlyCollection<T> readOnlyCollection)
          {
            return readOnlyCollection.Count;
          }

          return null;
        }
      }

      public bool HasBothCounts { get; }

      public int? CountExpected { get; }

      public int? CountActual { get; }
    }
  }
}