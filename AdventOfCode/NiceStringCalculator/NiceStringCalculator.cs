using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  public class NiceStringCalculator {
    public int GetNiceStringCount(string[] input) {
      var manager = new PropertyManager();
      manager.Add(new MinimalVowelCountProperty(new List<char>("aeiou".ToCharArray()), 3));
      manager.Add(new MinimalPluralityCountProperty(2, 1));
      manager.Add(new ForbiddenSubstringProperty(new List<string>() { "ab", "cd", "pq", "xy" }));
      return input.Count(s => manager.Satisfies(s));
    }

    public int GetNicerStringCount(string[] input) {
      var manager = new PropertyManager();
      manager.Add(new PatternMatchesTwiceWithoutOverlapProperty(2));
      manager.Add(new RepetitionOnNextPlaceProperty(1, 2));
      return input.Count(s => manager.Satisfies(s));
    }
  }
}