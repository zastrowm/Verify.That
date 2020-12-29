using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class EqualityExtensions
  {
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<T> ToEqual<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      FormattableString? message = null)
      => ToEqual(target, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<T> ToEqual<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IEqualityComparer<T> comparer,
      FormattableString? message = null)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;

          if (comparer == null)
          {
            var result = TryUseCollectionComparer(context, target.Value, comparisonValue);
            if (result != null)
            {
              return result.Value;
            }

            isUsingDefaultComparer = true;
            comparer = EqualityComparer<T>.Default;
          }

          bool didPass = comparer.Equals(target.Value, comparisonValue);
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: == {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:     {target}");
          }

          if (!isUsingDefaultComparer)
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }

    /// <summary>
    ///   Check if the target value is a type of <see cref="IEnumerable"/> and if so, attempt to compare
    ///   the elements instead of the using the default comparer, which would simply do a reference equal.
    /// </summary>
    private static bool? TryUseCollectionComparer(Context context, object? targetValue, object? comparisonValue)
    {
      // we let the rest of the system handle null
      if (targetValue == null
          || comparisonValue == null)
        return null;

      var typeInfo = new ReflectedTypeInfo(targetValue.GetType());

      if (typeInfo.DoesOverridesEquals
          || typeInfo.IEnumerableTypeImplemented == null)
        return null;

      Type elementType;

      if (typeInfo.IEnumerableTypeImplemented == typeof(IEnumerable))
      {
        // we need an instance of IEnumerable<T>
        targetValue = ((IEnumerable)targetValue).Cast<object>();
        elementType = typeof(object);
      }
      else
      {
        elementType = typeInfo.IEnumerableTypeImplemented.GetGenericArguments().Single();
      }

      return ElementComparer.Compare(context, elementType, (IEnumerable)targetValue, (IEnumerable)comparisonValue);
    }

    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<T> ToReferenceEqual<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      FormattableString? message = null)
      where T : class
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (ReferenceEquals(target.Value, comparisonValue))
          {
            return true;
          }

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: === {context.Wrap(comparisonValue)}");
            context.Writer.WriteLine($"But was:      {target}");
          }

          context.Writer.WriteLine($"(using reference comparer)");

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<T> ToNotReferenceEqual<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      FormattableString? message = null)
      where T : class
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (!ReferenceEquals(target.Value, comparisonValue))
          {
            return true;
          }

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: !== {context.Wrap(comparisonValue)}");
            context.Writer.WriteLine($"But was:      {target}");
          }

          context.Writer.WriteLine($"(using reference comparer)");

          return false;
        });
    }
  }
}