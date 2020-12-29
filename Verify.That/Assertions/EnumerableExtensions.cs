using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace VerifiedAssertions
{
  public static class EnumerableExtensions
  {
    /// <summary>
    ///   Verifies that the given IEnumerable equals another IEnumerable, element-wise
    /// </summary>
    public static IVerificationTarget<T> ToSequenceEqual<T>(
      this IVerificationTarget<T?> target,
      IEnumerable expectedValue
    )
      where T : IEnumerable
    {
      return CallbackAssertion.Create<T>(
        target!,
        context =>
        {
          var typeInfo = new ReflectedTypeInfo(typeof(T));
          IEnumerable? targetValue = target.Value;

          if (typeInfo.IEnumerableTypeImplemented == null)
            throw new InvalidOperationException("Invariant broken.  Non-enumerable type encountered but not expected");

          Type elementType;

          if (typeInfo.IEnumerableTypeImplemented == typeof(IEnumerable))
          {
            // we need an instance of IEnumerable<T>
            targetValue = targetValue?.Cast<object>();
            elementType = typeof(object);
          }
          else
          {
            elementType = typeInfo.IEnumerableTypeImplemented.GetGenericArguments().Single();
          }

          return ElementComparer.Compare(context, elementType, targetValue, expectedValue);
        }
      );
    }
  }
}