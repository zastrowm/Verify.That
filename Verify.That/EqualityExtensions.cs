using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class EqualityExtensions
  {
    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> EqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null)
      => EqualTo(value, comparisonValue, null, message);

    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> EqualTo<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      IEqualityComparer<T> comparer,
      FormattableString message = null)
    {
      return value.AddAssertion(new EqualityAssertion<T>(comparisonValue,
                                                         comparer,
                                                         message,
                                                         "=="));
    }
    
    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ReferenceEquals<T>(
      this IVerificationTarget<T> value,
      T comparisonValue,
      FormattableString message = null)
    where T : class
    {
      return value.AddAssertion(new EqualityAssertion<T>(comparisonValue,
                                                         ReferenceEqualityComparer<T>.Instance,
                                                         message,
                                                         "=="));
    }
    
    private class ReferenceEqualityComparer<T> : IEqualityComparer<T>
    {
      public static readonly ReferenceEqualityComparer<T> Instance
        = new ReferenceEqualityComparer<T>();
      
      public bool Equals(T x, T y)
        => Object.ReferenceEquals(x, y);

      public int GetHashCode(T obj)
        => obj?.GetHashCode() ?? -1;
    }
  }
}