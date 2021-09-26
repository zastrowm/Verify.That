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

    public static unsafe ValueVerificationTarget<IntPtr> ExpectPointer<T>(T* value)
      where T : unmanaged
      => new ValueVerificationTarget<IntPtr>((IntPtr)value);
  }
}