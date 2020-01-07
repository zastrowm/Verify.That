using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  // TODO
  public class Writer
  {
    public void Write(FormattableString str)
      => Console.Write(str.ToString());

    public void WriteLine(FormattableString str)
      => Console.WriteLine(str.ToString());

    public void WriteLine()
      => Console.WriteLine();
  }
}