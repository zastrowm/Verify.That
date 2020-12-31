using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VerifiedAssertions
{
  /// <summary>
  ///   The context to use when apply verifications.
  /// </summary>
  public class Context
  {
    private readonly MemoryStream _memoryStream;
    private StreamWriter _streamWriter;

    public Context()
    {
      _memoryStream = new MemoryStream();
      _streamWriter = new StreamWriter(_memoryStream, Encoding.UTF8);
      Writer = new Writer(_streamWriter);
    }

    public Writer Writer { get; }

    public string Wrap<T>(T value)
    {
      if (value is string str)
      {
        return StringLiteralConverter.ToLiteral(str);
      }

      // TODO
      return value?.ToString() ?? "<null>";
    }

    public void WriteMessage(FormattableString? message)
    {
      if (message != null)
      {
        Writer.WriteLine(message);
      }
    }

    internal string GetOutput()
    {
      _streamWriter.Flush();
      _memoryStream.Position = 0;
      using (var reader = new StreamReader(_memoryStream, Encoding.UTF8))
      {
        return reader.ReadToEnd();
      }
    }
  }
}