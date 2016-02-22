using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.NiceStringCalculator {
  internal class NiceStringCalculatorInput {

    private readonly List<string> _input;

    public NiceStringCalculatorInput(string path) {
      _input = new List<string>();
      try {
        using (var reader = new StreamReader(path)) {
          string line;
          while ((line = reader.ReadLine()) != null) {
            _input.Add(line);
          }
        }
      } catch (Exception) {
        throw new ApplicationException("Could not read the input file.");
      }
    }

    public List<string> GetInput() {
      return _input;
    }
  }
}