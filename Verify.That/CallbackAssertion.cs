using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Helper class for creation <see cref="VerifiedAssertions"/> using delegate callbacks.
  /// </summary>
  internal static class CallbackAssertion
  {
    /// <summary>
    ///   Delegate signature for a callback that checks if a given condition is true, and if not, writes error information
    ///   to the context source.
    /// </summary>
    /// <param name="context"> The context with which to write data into if the condition fails to be true. </param>
    public delegate bool ValidateAndWriteErrorCallback(Context context);
    
    public static IVerificationTarget<T> Create<T>(IVerificationTarget<T> target,
                                                   ValidateAndWriteErrorCallback callback)
    {
      if (target == null)
        throw new ArgumentNullException(nameof(target));
      if (callback == null)
        throw new ArgumentNullException(nameof(callback));

      target.AddAssertion(new CallbackBasedAssertion<T>(callback));
      return target;
    }

    private class CallbackBasedAssertion<T> : VerificationAssertion<T>
    {
      private readonly ValidateAndWriteErrorCallback _callback;

      public CallbackBasedAssertion(ValidateAndWriteErrorCallback callback)
      {
        _callback = callback;
      }

      /// <inheritdoc />
      public override bool Apply(IVerificationTarget<T> value, Context context)
      {
        if (value == null)
          throw new ArgumentNullException(nameof(value));
        if (context == null)
          throw new ArgumentNullException(nameof(context));

        return _callback.Invoke(context);
      }
    }
  }
}