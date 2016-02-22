using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  public class NiceStringCalculator {
    public int GetNiceStringCount(List<string> input) {
      var manager = new PropertyManager();
      manager.AddContainingAtLeastThreeVowelsProperty();
      manager.AddContainingAtLeastOneLetterAppearsTwiceProperty();
      manager.AddNotContainingForbiddenStringsProperty();
      return input.Count(s => manager.DoesSatisfy(s));
    }

    public int GetNicerStringCount(List<string> input) {
      var manager = new PropertyManager();
      manager.AddContainingPairOfLettersAppearingAtLeastTwiceWithoutOverlappingProperty();
      manager.AddContainingAtLeastOneLetterRepeatingWithExactlyOneLetterInbetweenProperty();
      return input.Count(s => manager.DoesSatisfy(s));
    }

  }
}