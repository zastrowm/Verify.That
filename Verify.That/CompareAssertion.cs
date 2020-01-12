using System;
using System.Collections.Generic;
using System.Linq;

namespace VerifiedAssertions
{
  /// <summary>
  ///   An assertion which takes in a <see cref="Comparer{T}"/> and compares two values.
  /// </summary>
  internal class CompareAssertion<T> : VerificationAssertion<T>
  {
    private readonly ValueToFormat<T> _comparisonValue;
    private readonly IComparer<T> _comparer;
    private readonly Func<int, bool> _resultComparer;
    private readonly string _character;
    private readonly string _nextLinePadding;
    private readonly bool _isUsingDefaultComparer;

    public CompareAssertion(T comparisonValue,
                            IComparer<T> comparer,
                            FormattableString message,
                            Func<int, bool> resultComparer,
                            string character)
      : base(message)
    {
      if (comparer == null)
      {
        _isUsingDefaultComparer = true;
        comparer = Comparer<T>.Default;
      }
      
      _resultComparer = resultComparer ?? throw new ArgumentNullException(nameof(resultComparer));
      
      _comparer = comparer;
      _character = character;
      _nextLinePadding = new string(' ', _character.Length);
      _comparisonValue = Wrap(comparisonValue);
    }

    /// <inheritdoc />
    public override bool Apply(IVerificationTarget<T> value, Context context)
    {
      int compareResult = _comparer.Compare(value.Value, _comparisonValue.Value);
      bool comparisonPasses = _resultComparer.Invoke(compareResult);
      
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
      else
      {
        writer.WriteLine($"(using custom comparer)");
      }

      return true;
    }
  }
}