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
    public static IVerificationTarget<T> GreaterThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null)
      where T : IComparable<T>
      => GreaterThan(value, comparisonValue, null, message);

    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> GreaterThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString message = null)
    {
      return value.AddAssertion(new CompareAssertion<T>(comparisonValue, comparer, message, i => i > 0, ">"));
    }

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T> GreaterThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null)
      where T : IComparable<T>
      => GreaterThanOrEqualTo(value, comparisonValue, null, message);

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T> GreaterThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString message = null)
    {
      return value.AddAssertion(new CompareAssertion<T>(comparisonValue, comparer, message, i => i >= 0, ">="));
    }

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null
    )
      where T : IComparable<T>
    {
      return LessThan(value, comparisonValue, null, message);
    }

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString message = null
    )
    {
      return value.AddAssertion(new CompareAssertion<T>(comparisonValue, comparer, message, i => i < 0, "<"));
    }

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null
    )
      => LessThanOrEqualTo(value, comparisonValue, null, message);

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      IComparer<T> comparer,
      FormattableString message = null
    )
    {
      return value.AddAssertion(new CompareAssertion<T>(comparisonValue, comparer, message, i => i <= 0, "<="));
    }
  }
}