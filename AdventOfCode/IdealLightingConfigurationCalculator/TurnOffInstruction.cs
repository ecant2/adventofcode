using System;
using System.Collections.Generic;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public class TurnOffInstruction : Instruction {

    private const string _instructionKeyWord = "turn off";

    public static string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public TurnOffInstruction(string input) : base(input, 9) {}

    public override void ExecuteOn(bool[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          lights[row, column] = false;
        }
      }
    }

    public override void ExecuteOn(int[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          if (lights[row, column] > 0)
            lights[row, column] -= 1;
        }
      }
    }
  }
}
