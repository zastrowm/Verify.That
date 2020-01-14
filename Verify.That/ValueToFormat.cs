using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Represents a value that should be formatted using any registered formatters when output to the test output
  ///   stream.
  /// </summary>
  public struct ValueToFormat<T>
  {
    public ValueToFormat(T value)
    {
      Value = value;
    }

    /// <summary>
    ///   The value that needs to be formatted.
    /// </summary>
    public T Value { get; }

    public override string ToString()
      => Value?.ToString() ?? "<null>";
  }
}