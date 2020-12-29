using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Assertions targeting <see cref="bool"/> and <see cref="Nullable{bool}"/>.
  /// </summary>
  public static class BooleanExtensions
  {
    /// <summary>
    ///   Verifies that the given value is equal to true.
    /// </summary>
    public static IVerificationTarget<bool> ToBeTrue(
      this IVerificationTarget<bool> target,
      FormattableString? message = null)
      => ExpectBooleanValue(target, true, message);

    /// <summary>
    ///   Verifies that the given value is equal to true.
    /// </summary>
    public static IVerificationTarget<bool?> ToBeTrue(
      this IVerificationTarget<bool?> target,
      FormattableString? message = null)
      => ExpectBooleanValue(target, true, message);

    /// <summary>
    ///   Verifies that the given value is equal to false.
    /// </summary>
    public static IVerificationTarget<bool> ToBeFalse(
      this IVerificationTarget<bool> target,
      FormattableString? message = null)
      => ExpectBooleanValue(target, false, message);

    /// <summary>
    ///   Verifies that the given value is equal to false.
    /// </summary>
    public static IVerificationTarget<bool?> ToBeFalse(
      this IVerificationTarget<bool?> target,
      FormattableString? message = null)
      => ExpectBooleanValue(target, false, message);

    private static IVerificationTarget<bool> ExpectBooleanValue(
      IVerificationTarget<bool> target,
      bool? expectedValue,
      FormattableString? message)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value == expectedValue)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: {expectedValue}");
            writer.WriteLine($"But was:  {target}");
          }

          return false;
        });
    }

    private static IVerificationTarget<bool?> ExpectBooleanValue(
      IVerificationTarget<bool?> target,
      bool? expectedValue,
      FormattableString? message)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value == expectedValue)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: {expectedValue}");
            writer.WriteLine($"But was:  {target}");
          }

          return false;
        });
    }
  }
}