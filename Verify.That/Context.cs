using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   The context to use when apply verifications.
  /// </summary>
  public class Context
  {
    public Writer Writer { get; }
      = new Writer();
  }
}