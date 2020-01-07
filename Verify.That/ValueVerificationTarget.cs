using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Implementation of <see cref="IVerificationTarget{T}"/> that simply applies all verifications as soon as they're
  ///   discovered.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class ValueVerificationTarget<T> : IVerificationTarget<T>
  {
    public ValueVerificationTarget(T value)
      => Value = value;

    public T Value { get; }
    
    public IVerificationTarget<T> AddAssertion(VerificationAssertion<T> assertion)
    {
      bool didFail = assertion.Apply(this, new Context());
      if (didFail)
        throw new InvalidOperationException("Assertion failure, see output");
      
      return this;
    }

    public IVerificationTarget<T> Is
      => this;

    /// <inheritdoc />
    public override string ToString()
      => Value?.ToString();
  }
}