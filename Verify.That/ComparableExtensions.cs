using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Verifications that target <see cref="IVerificationTarget{T}"/> where <typeparamref name="T"/> references a member
  ///   which implements <see cref="IComparable{T}/>
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
      => CreateComparer(value, comparisonValue, message, (l, r) => l.CompareTo(r) > 0, ">");

    /// <summary>
    ///   Verifies that the given value is greater than or equal to the comparison value.
    /// </summary>
    public static IVerificationTarget<T> GreaterThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null
    )
      where T : IComparable<T>
      => CreateComparer(value, comparisonValue, message, (l, r) => l.CompareTo(r) >= 0, ">=");

    /// <summary>
    ///   Verifies that the given value is less than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThan<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null
    )
      where T : IComparable<T>
      => CreateComparer(value, comparisonValue, message, (l, r) => l.CompareTo(r) < 0, "<");

    /// <summary>
    ///   Verifies that the given value is less or equal to than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> LessThanOrEqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null
    )
      where T : IComparable<T>
      => CreateComparer(value, comparisonValue, message, (l, r) => l.CompareTo(r) <= 0, "<=");

    private static IVerificationTarget<T> CreateComparer<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message,
      Func<T, T, bool> func,
      string prefix
    )
      where T : IComparable<T>
    {
      return value.AddAssertion(new ComparisonAssertion<T>(comparisonValue, message, func, prefix));
    }

    private class ComparisonAssertion<T> : VerificationAssertion<T>
      where T : IComparable<T>
    {
      private readonly Func<T, T, bool> _comparison;
      private readonly ValueToFormat<T> _comparisonValue;
      private readonly string _character;
      private readonly string _nextLinePadding;

      public ComparisonAssertion(T comparisonValue,
                                 FormattableString message,
                                 Func<T, T, bool> comparison,
                                 string character)
        : base(message)
      {
        _comparison = comparison;
        _character = character;
        _nextLinePadding = new string(' ', _character.Length);
        _comparisonValue = Wrap(comparisonValue);
      }

      /// <inheritdoc />
      public override bool Apply(IVerificationTarget<T> value, Context context)
      {
        bool comparisonPasses = _comparison.Invoke(value.Value, _comparisonValue.Value);
        if (comparisonPasses)
          return false;

        var writer = context.Writer;

        WriteMessage(context);
        writer.WriteLine($"Expected: {_character} {value}");
        writer.WriteLine($"But was:  {_nextLinePadding} {_comparisonValue}");

        return true;
      }
    }
  }
}