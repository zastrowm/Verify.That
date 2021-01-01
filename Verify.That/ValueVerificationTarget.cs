using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
      var context = new Context();
      bool didPass = assertion.Apply(this, context);
      if (!didPass)
        throw CreateException($"Assertion failure: {Environment.NewLine}{context.GetOutput()}");

      return this;
    }

    public IVerificationTarget<T> Is
      => this;

    /// <inheritdoc />
    public override string ToString()
      => Value?.ToString() ?? "<null>";

    private static Exception CreateException(string message)
    {
      if (XUnitException.Value is Type type)
      {
        return (Exception)Activator.CreateInstance(type, message)!;
      }

      return new InvalidOperationException(message);
    }

    private static Lazy<Type?> XUnitException = new(
      () =>
      {
        try
        {
          var assembly = Assembly.Load(new AssemblyName("xunit.assert"));
          return assembly.GetType("Xunit.Sdk.XunitException");
        }
        catch
        {
          return null;
        }
      }
    );
  }
}