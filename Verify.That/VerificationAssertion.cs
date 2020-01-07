using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Abstract class for a verification that can be applied to a given value to assert that it has a given
  ///   characteristic.
  /// </summary>
  public abstract class VerificationAssertion<T>
  {
    protected VerificationAssertion(FormattableString message)
    {
      Message = message;
    }

    protected FormattableString Message { get; }

    protected ValueToFormat<T> Wrap(T value)
      => new ValueToFormat<T>(value);

    public abstract bool Apply(IVerificationTarget<T> value, Context context);

    protected void WriteMessage(Context context)
    {
      if (Message == null)
        return;

      context.Writer.WriteLine(Message);
    }
  }
}