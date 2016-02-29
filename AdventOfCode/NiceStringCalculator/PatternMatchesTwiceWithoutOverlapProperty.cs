using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.NiceStringCalculator {
  public class PatternMatchesTwiceWithoutOverlapProperty : Property {
    private readonly int _patternLength;

    public PatternMatchesTwiceWithoutOverlapProperty(int patternLength) {
      _patternLength = patternLength;
    }

    public bool Satisfies(string input) {
      for (var index = 0; index <= input.Length - _patternLength; index++) {
        var pattern = input.Substring(index, _patternLength);
        var remaining = input.Substring(index + _patternLength, input.Length - index - _patternLength);
        if (remaining.Contains(pattern))
          return true;
      }
      return false;
    }
  }
}
