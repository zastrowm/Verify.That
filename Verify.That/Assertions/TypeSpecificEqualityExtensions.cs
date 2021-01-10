using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class TypeSpecificEqualityExtensions
  {
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<float> ToEqual(
      this IVerificationTarget<float> target,
      float comparisonValue,
      int precision,
      FormattableString? message = null
    )
    {
      return target.ToEqual(comparisonValue, message: message, comparer: new PrecisionComparer(precision));
    }

    private class PrecisionComparer
      : IEqualityComparer<float>
    {
      private readonly int _precision;

      public PrecisionComparer(int precision)
      {
        _precision = precision;
      }

      public bool Equals(float x, float y)
      {
        x = (float)Math.Round(x, _precision);
        y = (float)Math.Round(y, _precision);

        return Math.Abs(x - y) < float.Epsilon;
      }

      public int GetHashCode(float obj)
        => obj.GetHashCode();

      public override string ToString()
        => $"Epsilon Comparer (precision={_precision})";
    }
  }
}