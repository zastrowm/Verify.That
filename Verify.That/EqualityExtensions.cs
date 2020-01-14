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
      FormattableString? message = null)
      => EqualTo(value, comparisonValue, null!, message);

    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> EqualTo<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      IEqualityComparer<T> comparer,
      FormattableString? message = null)
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          bool isUsingDefaultComparer = false;
          if (comparer == null)
          {
            isUsingDefaultComparer = true;
            comparer = EqualityComparer<T>.Default;;
          }

          bool didPass = comparer.Equals(target.Value, comparisonValue);
          if (didPass)
          {
            return true;
          }

          var writer = context.Writer;

          context.WriteMessage(message);

          using (writer.Indent())
          {
            writer.WriteLine($"Expected: == {context.Wrap(comparisonValue)}");
            writer.WriteLine($"But was:     {target}");
          }

          if (!isUsingDefaultComparer)
          {
            writer.WriteLine($"(using custom comparer)");
          }

          return false;
        });
    }
    
    /// <summary>
    ///   Verifies that the given value is greater than the comparison value.
    /// </summary>
    public static IVerificationTarget<T> ReferenceEquals<T>(
      this IVerificationTarget<T> target,
      T comparisonValue,
      FormattableString? message = null)
    where T : class
    {
      return CallbackAssertion.Create(
        target,
        context =>
        {
          if (ReferenceEquals(target.Value, comparisonValue))
          {
            return true;
          }

          context.WriteMessage(message);

          using (context.Writer.Indent())
          {
            context.Writer.WriteLine($"Expected: === {context.Wrap(comparisonValue)}");
            context.Writer.WriteLine($"But was:      {target}");
          }

          context.Writer.WriteLine($"(using reference comparer)");

          return false;
        });
    }
  }
}