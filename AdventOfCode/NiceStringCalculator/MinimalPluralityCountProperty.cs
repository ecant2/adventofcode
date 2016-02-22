using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  public class MinimalPluralityCountProperty : Property {

    private readonly int _plurality ;
    private readonly int _matchesCount;

    public MinimalPluralityCountProperty(int plurality, int matchesCount) {
      _plurality = plurality;
      _matchesCount = matchesCount;
    }

    public bool DoesSatisfy(string input) {
      var matches = 0;
      foreach (var dupliatedCharacter in input.Select(c => string.Concat(Enumerable.Repeat(c, _plurality)))) {
        if (input.Contains(dupliatedCharacter))
          matches++;
        if (matches == _matchesCount)
          return true;
      }
      return false;
    }
  }
}
