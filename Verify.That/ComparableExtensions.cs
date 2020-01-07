using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Verifications that target <see cref="IVerificationTarget{T}"/> where <typeparamref name="T"/> references a member
  ///   which implements <see cref="IComparable{T}./>
  /// </summary>
  public static class ComparableExtensions
  {
    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> GreaterThan<T>(this IVerificationTarget<T> value,
                                                        T comparisonValue,
                                                        FormattableString message = null)
      where T : IComparable<T>
    {
      return value.AddAssertion(new GreaterThanAssertion<T>(comparisonValue, message));
    }
    
    private class GreaterThanAssertion<T> : VerificationAssertion<T>
      where T : IComparable<T>
    {
      private readonly ValueToFormat<T> _comparisonValue;

      public GreaterThanAssertion(T comparisonValue, FormattableString message)
        : base(message)
      {
        _comparisonValue = Wrap(comparisonValue);
      }

      /// <inheritdoc />
      public override bool Apply(IVerificationTarget<T> value, Context context)
      {
        bool isGreaterThan = value.Value.CompareTo(_comparisonValue.Value) > 0;
        if (isGreaterThan)
          return false;
        
        var writer = context.Writer;
        
        WriteMessage(context);
        writer.WriteLine($"Expected: > {value}");
        writer.WriteLine($"But was:    {_comparisonValue}");

        return true;
      }
    }
  }
}