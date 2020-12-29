using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Verifications that target <see cref="IVerificationTarget{T}"/>.
  /// </summary>
  public static class ComparableExtensions
  {
    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T?> ToBeGreaterThan<T>(
      this IVerificationTarget<T?> value,
      T comparisonValue,
      FormattableString? message = null)
      where T : struct, IComparable<T>
      => ToBeGreaterThan(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeGreaterThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString? message = null)
      where T : IComparable<T>
      => ToBeGreaterThan(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeGreaterThan<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString? message = null)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;
          if (comparer == null)
          {
            isUsingDefaultComparer = true;
            comparer = Comparer<T>.Default;
          }

          bool didPass = comparer.Compare(target.Value, comparisonValue) > 0;
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: > {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:    {target}");
          }

          if (isUsingDefaultComparer)
          {
            writer.WriteLine($"(using default comparer)");
          }
          else
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T?> ToBeGreaterThanOrEqualTo<T>(
      this IVerificationTarget<T?> value,
      T comparisonValue,
      FormattableString? message = null)
      where T : struct, IComparable<T>
      => ToBeGreaterThanOrEqualTo(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeGreaterThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString? message = null)
      where T : IComparable<T>
      => ToBeGreaterThanOrEqualTo(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeGreaterThanOrEqualTo<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString? message = null)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;
          if (comparer == null)
          {
            isUsingDefaultComparer = true;
            comparer = Comparer<T>.Default;
          }

          bool didPass = comparer.Compare(target.Value, comparisonValue) >= 0;
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: >= {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:     {target}");
          }

          if (isUsingDefaultComparer)
          {
            writer.WriteLine($"(using default comparer)");
          }
          else
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T?> ToBeLessThan<T>(
      this IVerificationTarget<T?> value,
      T comparisonValue,
      FormattableString? message = null
    )
      where T : struct, IComparable<T>
    {
      return ToBeLessThan(value, comparisonValue, null!, message);
    }

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeLessThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString? message = null
    )
      where T : IComparable<T>
    {
      return ToBeLessThan(value, comparisonValue, null!, message);
    }

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeLessThan<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString? message = null
    )
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;
          if (comparer == null)
          {
            isUsingDefaultComparer = true;
            comparer = Comparer<T>.Default;
          }

          bool didPass = comparer.Compare(target.Value, comparisonValue) < 0;
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: < {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:    {target}");
          }

          if (isUsingDefaultComparer)
          {
            writer.WriteLine($"(using default comparer)");
          }
          else
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T?> ToBeLessThanOrEqualTo<T>(
      this IVerificationTarget<T?> value,
      T comparisonValue,
      FormattableString? message = null
    )
      where T : struct, IComparable<T>
      => ToBeLessThanOrEqualTo(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeLessThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString? message = null
    )
      where T : IComparable<T>
      => ToBeLessThanOrEqualTo(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ToBeLessThanOrEqualTo<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString? message = null
    )
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;
          if (comparer == null)
          {
            isUsingDefaultComparer = true;
            comparer = Comparer<T>.Default;
          }

          bool didPass = comparer.Compare(target.Value, comparisonValue) >= 0;
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: <= {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:     {target}");
          }

          if (isUsingDefaultComparer)
          {
            writer.WriteLine($"(using default comparer)");
          }
          else
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }
  }
}