using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Entry point for VerifiedAssertions.
  /// </summary>
  public static class Verify
  {
    public static ValueVerificationTarget<T> That<T>(T value)
      => new ValueVerificationTarget<T>(value);
  }
}