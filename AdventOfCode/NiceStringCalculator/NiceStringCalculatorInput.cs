using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.NiceStringCalculator {
  internal class NiceStringCalculatorInput {
    private readonly string _path;

    public NiceStringCalculatorInput(string path) {
      _path = path;
    }

    public string[] GetInput() {
      return File.ReadAllLines(_path);
    }
  }
}