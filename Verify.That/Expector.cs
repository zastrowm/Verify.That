using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  /// Introduction point for verifications.  Uses the form:
  /// <code>
  /// I.Expect(value)
  ///  .ToEqual(somethingElse)
  /// </code>
  /// </summary>
  public static class I
  {
    public static ValueVerificationTarget<T> Expect<T>(T value)
      => new ValueVerificationTarget<T>(value);
  }
}