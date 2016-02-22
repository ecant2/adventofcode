using System;
using System.Collections.Generic;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public class TurnOnInstruction : Instruction {

    private const string _instructionKeyWord = "turn on";

    public static string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public TurnOnInstruction(string input) : base(input, 8) {}

    public override void ExecuteOn(bool[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          lights[row, column] = true;
        }
      }
    }

    public override void ExecuteOn(int[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          lights[row, column] += 1;
        }
      }
    }
  }
}
