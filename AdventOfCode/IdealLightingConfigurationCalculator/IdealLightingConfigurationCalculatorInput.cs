using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  class IdealLightingConfigurationCalculatorInput {
    private readonly List<Instruction> _input;

    public IdealLightingConfigurationCalculatorInput(string path) {
      _input = new List<Instruction>();
      try {
        using (var reader = new StreamReader(path)) {
          string line;
          while ((line = reader.ReadLine()) != null) {
            _input.Add(InstructionFactory.GetInstruction(line));
          }
        }
      } catch (Exception) {
        throw new ApplicationException("Could not read the input file.");
      }
    }

    public List<Instruction> GetInput() {
      return _input;
    }
  }
}
