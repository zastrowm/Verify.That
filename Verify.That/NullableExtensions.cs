using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class NullableExtensions
  {
    /// <summary>
    ///   Verifies that the given value is null.
    /// </summary>
    public static IVerificationTarget<T> Null<T>(
      this IVerificationTarget<T> target,
      FormattableString? message = null)
    where T : class
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value == null)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: <null>");
            context.Writer.WriteLine($"But was:  {target}");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is null.
    /// </summary>
    public static IVerificationTarget<T?> Null<T>(
      this IVerificationTarget<T?> target,
      FormattableString? message = null)
      where T : struct
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (!target.Value.HasValue)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: <null>");
            context.Writer.WriteLine($"But was:  {target.Value.Value}");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is not null.
    /// </summary>
    public static IVerificationTarget<T> NotNull<T>(
      this IVerificationTarget<T> target,
      FormattableString? message = null)
      where T : class
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (target.Value != null)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: not <null>");
            context.Writer.WriteLine($"But was:  <null>");
          }

          return false;
        });
    }

    /// <summary>
    ///   Verifies that the given value is not null.
    /// </summary>
    public static IVerificationTarget<T?> NotNull<T>(
      this IVerificationTarget<T?> target,
      FormattableString? message = null)
      where T : struct
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (!target.Value.HasValue)
            return true;

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: not <null>");
            context.Writer.WriteLine($"But was:  <null>");
          }

          return false;
        });
    }
  }
}