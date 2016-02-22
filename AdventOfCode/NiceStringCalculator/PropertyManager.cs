using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  internal class PropertyManager {

    private readonly List<Property> _allProperties;

    public PropertyManager() {
      _allProperties = new List<Property>();
    }

    public void AddContainingAtLeastThreeVowelsProperty() {
      _allProperties.Add(new MinimalVowelCountProperty(new List<char>("aeiou".ToCharArray()), 3));
    }

    public void AddContainingAtLeastOneLetterAppearsTwiceProperty() {
      _allProperties.Add(new MinimalPluralityCountProperty(2, 1));
    }

    public void AddNotContainingForbiddenStringsProperty() {
      _allProperties.Add(new ForbiddenSubstringProperty(new List<string>() { "ab", "cd", "pq", "xy" }));
    }

    public void AddContainingPairOfLettersAppearingAtLeastTwiceWithoutOverlappingProperty() {
      _allProperties.Add(new PatternMatchesTwiceWithoutOverlapProperty(2));
    }

    public void AddContainingAtLeastOneLetterRepeatingWithExactlyOneLetterInbetweenProperty() {
      _allProperties.Add(new RepetitionOnNextPlaceProperty(1, 2));
    }

    public bool DoesSatisfy(string input) {
      return _allProperties.Aggregate(true, (current, property) => current & property.DoesSatisfy(input));
    }
  }
}
