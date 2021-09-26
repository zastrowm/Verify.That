using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class PointerEqualityExtensions
  {
    /// <summary>
    ///   Verifies that the given value is null.
    /// </summary>
    public static unsafe IVerificationTarget<IntPtr> ToEqual<T>(
      this IVerificationTarget<IntPtr> target,
      T* value,
      FormattableString? message = null
    )
      where T : unmanaged
      => ToEqual(target, (IntPtr)value, message);

    /// <summary>
    ///   Verifies that the given value is null.
    /// </summary>
    public static IVerificationTarget<IntPtr> ToEqual(
      this IVerificationTarget<IntPtr> target,
      IntPtr value,
      FormattableString? message = null
    )
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value == value)
            return true;

          context.WriteMessage(message);

          long diff = (nint)value - target.Value;

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: {(long)value}");
            context.Writer.WriteLine($"But was:  {(long)target.Value}");
            context.Writer.WriteLine($"(difference is {diff})");
          }

          return false;
        }
      );
    }

    /// <summary>
    ///   Verifies that the given value is null.
    /// </summary>
    public static IVerificationTarget<IntPtr> ToBeNull(
      this IVerificationTarget<IntPtr> target,
      FormattableString? message = null
    )
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value == IntPtr.Zero)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: <null>");
            context.Writer.WriteLine($"But was:  {target}");
          }

          return false;
        }
      );
    }

    /// <summary>
    ///   Verifies that the given value is not null.
    /// </summary>
    public static IVerificationTarget<IntPtr> ToBeNonNull(
      this IVerificationTarget<IntPtr> target,
      FormattableString? message = null
    )
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value != IntPtr.Zero)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: not <null>");
            context.Writer.WriteLine($"But was:  <null>");
          }

          return false;
        }
      );
    }
  }
}