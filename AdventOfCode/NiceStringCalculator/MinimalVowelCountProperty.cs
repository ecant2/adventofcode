using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  public class MinimalVowelCountProperty : Property {

    private readonly List<char> _vowels;
    private readonly int _matchesCount;

    public MinimalVowelCountProperty(List<char> vowels, int matchesCount) {
      _vowels = vowels;
      _matchesCount = matchesCount;
    }

    public bool Satisfies(string input) {
      var matches = 0;
      for (var index = 0; index < _vowels.Count; index++) {
        var currentmatch = input.Count(x => x == _vowels.ElementAt(index));
        matches += currentmatch;
        if (matches >= _matchesCount)
          return true;
      }
      return false;
    }
  }
}
