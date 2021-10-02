using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{

  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      int comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      uint comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      long comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<byte> ToEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<byte> ToNotEqual(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IEqualityComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThan(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThan(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<byte> ToBeLessThanOrEqualTo(
      this IVerificationTarget<byte> target,
      ulong comparisonValue,
      IComparer<byte> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((byte)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      int comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      uint comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      long comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<short> ToEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<short> ToNotEqual(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IEqualityComparer<short> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThan(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<short> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThan(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<short> ToBeLessThanOrEqualTo(
      this IVerificationTarget<short> target,
      ulong comparisonValue,
      IComparer<short> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((short)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      int comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      short comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      long comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToEqual(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<ushort> ToNotEqual(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IEqualityComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThan(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThan(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<ushort> ToBeLessThanOrEqualTo(
      this IVerificationTarget<ushort> target,
      ulong comparisonValue,
      IComparer<ushort> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((ushort)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      int comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      long comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is equal to the given value. </summary>
    public static IVerificationTarget<uint> ToEqual(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class EqualityExtensions
  {
    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is not equal to the given value. </summary>
    public static IVerificationTarget<uint> ToNotEqual(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IEqualityComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToNotEqual(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThan(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is greater than or equal to the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeGreaterThanOrEqualTo(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeGreaterThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThan(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThan(target, checked((uint)comparisonValue), comparer, message);
  }
  public static partial class ComparableExtensions
  {
    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), null!, message);

    /// <summary> Verifies that the given value is less or equal to than the comparison value. </summary>
    public static IVerificationTarget<uint> ToBeLessThanOrEqualTo(
      this IVerificationTarget<uint> target,
      ulong comparisonValue,
      IComparer<uint> comparer,
      FormattableString? message = null
    )
      => ToBeLessThanOrEqualTo(target, checked((uint)comparisonValue), comparer, message);
  }
}