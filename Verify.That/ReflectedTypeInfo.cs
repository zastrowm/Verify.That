using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   Contains information about a type that's useful to the assertion library.
  /// </summary>
  internal class ReflectedTypeInfo
  {
    private static readonly Dictionary<Type, ReflectedTypeInfo> TypeInfoLookup
      = new Dictionary<Type, ReflectedTypeInfo>();

    public ReflectedTypeInfo(Type type)
    {
      DoesOverridesEquals = CheckIfOverridesEqual(type);
      IEnumerableTypeImplemented = GetImplementedIEnumerable(type);
    }

    private static Type? GetImplementedIEnumerable(Type type)
    {
      var typeImplemented = typeof(IEnumerable);

      if (!typeof(IEnumerable).IsAssignableFrom(type))
        return null;

      // we want to check for an implementation of the generic form of the type
      var enumerableTypesImplemented =
        type.GetInterfaces()
            .Where(t => t.IsGenericType && !t.IsGenericTypeDefinition)
            .Where(t => t.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            .ToArray();

      // but only take it if there's one
      if (enumerableTypesImplemented.Length == 1)
      {
        typeImplemented = enumerableTypesImplemented[0];
      }

      // defaulting to the non-generic version
      return typeImplemented;
    }

    /// <summary>
    ///  True if the type overrides .Equals
    /// </summary>
    public bool DoesOverridesEquals { get; }

    /// <summary>
    ///  The type of <see cref="IEnumerable"/> or <see cref="IEnumerable{T}"/> that the type implements. 
    /// </summary>
    public Type? IEnumerableTypeImplemented { get; }

    private static bool CheckIfOverridesEqual(Type type)
    {
      var equalsMethod = type.GetMethod(nameof(Equals), new[] { typeof(object) });
      return equalsMethod != null
             && equalsMethod.IsVirtual 
             && equalsMethod.DeclaringType != typeof(object);
    }

    public static ReflectedTypeInfo GetTypeInfo(Type type)
    {
      lock (TypeInfoLookup)
      {
        if (!TypeInfoLookup.TryGetValue(type, out var info))
        {
          info = new ReflectedTypeInfo(type);
          TypeInfoLookup[type] = info;
        }

        return info;
      }
    }
  }
}