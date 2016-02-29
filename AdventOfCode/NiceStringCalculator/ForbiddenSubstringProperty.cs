using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  public class ForbiddenSubstringProperty : Property {

    private readonly List<string> _forbiddenSubstrings; 

    public ForbiddenSubstringProperty(List<string> forbiddenSubstrings) {
      _forbiddenSubstrings = forbiddenSubstrings;
    }

    public bool Satisfies(string input) {
      return !_forbiddenSubstrings.Any(input.Contains);
    }
  }
}
