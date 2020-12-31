using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifiedAssertions
{
  // TODO
  public class Writer
  {
    private readonly DedentOnDisposable _disposable;
    private readonly IndentedTextWriter _writer;

    public Writer(TextWriter writer)
    {
      _writer = new IndentedTextWriter(writer);
      _disposable = new DedentOnDisposable(_writer);
    }

    public void Write(FormattableString str)
    {
      if (str == null)
        throw new ArgumentNullException(nameof(str));

      _writer.Write(str.ToString());
    }

    public void WriteNoteLine(FormattableString str)
    {
      if (str == null)
        throw new ArgumentNullException(nameof(str));

      _writer.Write(" -note- ");
      _writer.WriteLine(str.ToString());
    }

    public void WriteNoteNext(FormattableString str)
    {
      if (str == null)
        throw new ArgumentNullException(nameof(str));

      _writer.Write("      ┕ ");
      _writer.WriteLine(str.ToString());
    }

    public void WriteLine(FormattableString str)
    {
      if (str == null)
        throw new ArgumentNullException(nameof(str));

      _writer.WriteLine(str.ToString());
    }

    public void WriteLine()
      => _writer.WriteLine();

    /// <summary>
    ///   Indent all lines written inside of the scope defined by the <see cref="IDisposable"/> that is returned.
    /// </summary>
    public IDisposable Indent()
    {
      _writer.Indent();
      return _disposable;
    }

    /// <summary>
    ///   Custom <see cref="TextWriter"/> that can indent subsequent lines.
    /// </summary>
    private class IndentedTextWriter : TextWriter
    {
      private readonly TextWriter _wrapped;
      private int _indent;
      private bool _lastWrittenWasNewLine;

      public IndentedTextWriter(TextWriter wrapped)
      {
        _lastWrittenWasNewLine = true;
        _wrapped = wrapped;
      }

      public void Indent()
        => _indent++;

      public void Dedent()
      {
        _indent--;
        if (_indent < 0)
        {
          _indent = 0;
        }
      }

      public override void Write(char value)
      {
        if (value == '\n')
        {
          _lastWrittenWasNewLine = true;
        }
        else if (_lastWrittenWasNewLine)
        {
          _lastWrittenWasNewLine = false;
          WriteIndent();
        }

        _wrapped.Write(value);
      }

      private void WriteIndent()
      {
        for (int i = 0; i < _indent; i++)
        {
          _wrapped.Write(' ');
          _wrapped.Write(' ');
        }
      }

      /// <inheritdoc />
      public override void Flush()
        => _wrapped.Flush();

      /// <inheritdoc />
      public override Task FlushAsync()
        => _wrapped.FlushAsync();

      /// <inheritdoc />
      protected override void Dispose(bool disposing)
        => _wrapped.Dispose();

#if NETCOREAPP
      /// <inheritdoc />
      public override ValueTask DisposeAsync()
        => _wrapped.DisposeAsync();
#endif

      /// <inheritdoc />
      public override Encoding Encoding
        => _wrapped.Encoding;
    }

    /// <summary>
    ///   Helper class so that the return value of <see cref="Writer.Indent"/>, when disposed, will dedent.
    /// </summary>
    private class DedentOnDisposable : IDisposable
    {
      private readonly IndentedTextWriter _owner;

      public DedentOnDisposable(IndentedTextWriter owner)
      {
        _owner = owner;
      }

      public void Dispose()
        => _owner.Dedent();
    }
  }
}