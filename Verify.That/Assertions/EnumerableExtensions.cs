using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace VerifiedAssertions
{
  public static class EnumerableExtensions
  {
    /// <summary>
    ///   Verifies that the enumerable has the given length or count.
    /// </summary>
    public static IVerificationTarget<T> ToHaveCount<T>(
      this IVerificationTarget<T?> target,
      int length,
      FormattableString? message = null
    )
      where T : IEnumerable
    {
      return ToHaveLength(target, length, message);
    }

    /// <summary>
    ///   Verifies that the enumerable has the given length or count.
    /// </summary>
    public static IVerificationTarget<T> ToHaveLength<T>(
      this IVerificationTarget<T?> target,
      int expectedLength,
      FormattableString? message = null
    )
      where T : IEnumerable
    {
      return CallbackAssertion.Create<T>(
        target!,
        context =>
        {
          var writer = context.Writer;

          if (target.Value == null)
          {
            context.WriteMessage(message);

            using (writer.Indent())
            {
              writer.WriteLine($"Expected: == non-null enumerable with count/length of {expectedLength}");
              writer.WriteLine($"But was:     {target}");
            }

            return false;
          }

          int actualCount = (target.Value as ICollection)?.Count ?? target.Value.OfType<object>().Count();

          if (actualCount != expectedLength)
          {
            context.WriteMessage(message);

            using (writer.Indent())
            {
              writer.WriteLine($"Expected count: {expectedLength}");
              writer.WriteLine($"But was:        {actualCount}");
            }

            return false;
          }

          return true;
        }
      );
    }

    /// <summary>
    ///   Verifies that the given IEnumerable equals another IEnumerable, element-wise
    /// </summary>
    public static IVerificationTarget<T> ToSequenceEqual<T>(
      this IVerificationTarget<T?> target,
      IEnumerable expectedValue
    )
      where T : IEnumerable
    {
      return CallbackAssertion.Create<T>(
        target!,
        context =>
        {
          var typeInfo = new ReflectedTypeInfo(typeof(T));
          IEnumerable? targetValue = target.Value;

          if (typeInfo.IEnumerableTypeImplemented == null)
            throw new InvalidOperationException("Invariant broken.  Non-enumerable type encountered but not expected");

          Type elementType;

          if (typeInfo.IEnumerableTypeImplemented == typeof(IEnumerable))
          {
            // we need an instance of IEnumerable<T>
            targetValue = targetValue?.Cast<object>();
            elementType = typeof(object);
          }
          else
          {
            elementType = typeInfo.IEnumerableTypeImplemented.GetGenericArguments().Single();
          }

          return ElementComparer.Compare(context, elementType, targetValue, expectedValue);
        }
      );
    }
  }
}