using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public static class TestClass
  {
    public static void Main()
    {
      
      Try(delegate
          {
            Verify.That("5")
                  .Is.ToEqual("6");
          });
      
      Try(delegate
          {
            Verify.That("n")
                  .Is.ToBeGreaterThan("m", $"'n' <= 'm' somehow!")
                  .Is.ToBeLessThan("m");
          });

      Try(delegate
          {
            Verify.That("5")
                  .Is.ToBeGreaterThan("6", $"Expected Failure");
          });
      
      Try(delegate
          {
            Verify.That(new It())
                  .Is.ToBeGreaterThan(new It(),
                                  Comparer<It>.Create((l, r) => l.Property.CompareTo(r.Property)),
                                  $"Expected Failure");
          });
    }

    public struct It
    {
      public int Property { get; }

      public override string ToString()
        => "<It>" + Property.ToString();
    }

    public static void Try(Action callback)
    {
      try
      {
        callback.Invoke();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    }
  }
}