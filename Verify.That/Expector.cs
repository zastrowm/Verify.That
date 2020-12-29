using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Static class to contain standalone "Expect" method.
  /// </summary>
  public static class Expector
  {
    public static ValueVerificationTarget<T> Expect<T>(T value)
      => new ValueVerificationTarget<T>(value);
  }
}