using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  public interface IWrappedValue<T>
  {
    T OriginalValue { get; }
  }

  internal class CallbackAssertion<T> : VerificationAssertion<T>
  {
    private readonly Func<T, T, bool> _comparison;
    private readonly ValueToFormat<T> _comparisonValue;
    private readonly string _character;
    private readonly string _nextLinePadding;

    public CallbackAssertion(T comparisonValue,
                             FormattableString message,
                             Func<T, T, bool> comparison,
                             string character)
      : base(message)
    {
      _comparison = comparison;
      _character = character;
      _nextLinePadding = new string(' ', _character.Length);
      _comparisonValue = Wrap(comparisonValue);
    }

    /// <inheritdoc />
    public override bool Apply(IVerificationTarget<T> value, Context context)
    {
      bool comparisonPasses = _comparison.Invoke(value.Value, _comparisonValue.Value);
      if (comparisonPasses)
        return false;

      var writer = context.Writer;

      WriteMessage(context);
      writer.WriteLine($"Expected: {_character} {value}");
      writer.WriteLine($"But was:  {_nextLinePadding} {_comparisonValue}");

      return true;
    }
  }
}