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
    public abstract bool Apply(IVerificationTarget<T> value, Context context);
  }
}