using System;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public class ToggleInstruction : Instruction {

    private const string _instructionKeyWord = "toggle";

    public static string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public ToggleInstruction(string input) : base(input, 7) {}

    public override void ExecuteOn(bool[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          lights[row, column] = !lights[row, column];
        }
      }
    }

    public override void ExecuteOn(int[,] lights) {
      for (int row = X1; row <= X2; row++) {
        for (int column = Y1; column <= Y2; column++) {
          lights[row, column] += 2;
        }
      }
    }
  }
}
