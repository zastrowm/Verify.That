using System;
using System.Collections.Generic;
using System.Linq;


namespace VerifiedAssertions
{
  public static partial class EqualityExtensions
  {
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<byte>(target, (byte)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, comparer, message); }
    }
    /// <summary>
    ///   Verifies that the given value is equal to the given value.
    /// </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, null!, message); }
    }

   /// <summary>
   ///   Verifies that the given value is equal to the given value.
   /// </summary>
   public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
    {
      checked { return ToEqual<short>(target, (short)comparisonValue, comparer, message); }
    }
  }
}