using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class TestClass
  {
    public static void Main()
    {
      Verify.That("n")
            .Is.GreaterThan("m", $"'n' <= 'm' somehow!");
      
      Verify.That("5")
            .Is.GreaterThan("6", $"Expected Failure");
    }
  }
}