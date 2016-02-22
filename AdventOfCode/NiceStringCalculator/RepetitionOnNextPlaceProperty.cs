using System;

namespace AdventOfCode.NiceStringCalculator {
  public class RepetitionOnNextPlaceProperty : Property {

    private readonly int _patternLength;
    private readonly int _placesFurther;

    public RepetitionOnNextPlaceProperty(int patternLength, int placesFurther) {
      _patternLength = patternLength;
      _placesFurther = placesFurther;
    }

    public bool DoesSatisfy(string input) {
      for (int index = 0; index <= input.Length - _patternLength - _placesFurther; index++) {
        var pattern = input.Substring(index, _patternLength);
        var possibleRepetition = input.Substring(index + _placesFurther, _patternLength);
        if (pattern.Equals(possibleRepetition))
          return true;
      }
      return false;
    }
  }
}
