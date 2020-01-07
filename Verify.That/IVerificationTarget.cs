using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   A value that is intended to be validated in some way.
  /// </summary>
  /// <typeparam name="T"> The type of value being verified. </typeparam>
  public interface IVerificationTarget<T>
  {
    /// <summary>
    ///   The value to validate.
    /// </summary>
    T Value { get; }

    /// <summary>
    ///   Adds an assertion that should be used to verify that the value meets expectations.
    /// </summary>
    /// <param name="assertion"> The assertion that may be used to verify the expectations of the caller. </param>
    IVerificationTarget<T> AddAssertion(VerificationAssertion<T> assertion);
  }
}