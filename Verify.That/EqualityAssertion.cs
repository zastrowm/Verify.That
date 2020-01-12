using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   An assertion which takes in a <see cref="Comparer{T}"/> and compares two values.
  /// </summary>
  internal class EqualityAssertion<T> : VerificationAssertion<T>
  {
    private readonly ValueToFormat<T> _comparisonValue;
    private readonly IEqualityComparer<T> _comparer;
    private readonly string _character;
    private readonly string _nextLinePadding;
    private readonly bool _isUsingDefaultComparer;

    public EqualityAssertion(T comparisonValue,
                             IEqualityComparer<T> comparer,
                             FormattableString message,
                             string character)
      : base(message)
    {
      if (comparer == null)
      {
        _isUsingDefaultComparer = true;
        comparer = EqualityComparer<T>.Default;
      }
      
      _comparer = comparer;
      _character = character;
      _nextLinePadding = new string(' ', _character.Length);
      _comparisonValue = Wrap(comparisonValue);
    }

    /// <inheritdoc />
    public override bool Apply(IVerificationTarget<T> value, Context context)
    {
      bool comparisonPasses = _comparer.Equals(value.Value, _comparisonValue.Value);
      
      if (comparisonPasses)
        return false;

      var writer = context.Writer;

      WriteMessage(context);

      using (writer.Indent())
      {
        writer.WriteLine($"Expected: {_character} {value}");
        writer.WriteLine($"But was:  {_nextLinePadding} {_comparisonValue}");
      }
      
      if (_isUsingDefaultComparer)
      {
        writer.WriteLine($"(using default comparer)");
      }

      return true;
    }
  }
}