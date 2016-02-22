using System;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public class InstructionFactory {

    public static Instruction GetInstruction(string input) {
      if (input.StartsWith(ToggleInstruction.GetInstructionKeyWord()))
        return new ToggleInstruction(input);
      if (input.StartsWith(TurnOffInstruction.GetInstructionKeyWord()))
        return new TurnOffInstruction(input);
      if (input.StartsWith(TurnOnInstruction.GetInstructionKeyWord()))
        return new TurnOnInstruction(input);
      throw new ApplicationException("Incorrect instruction: " + input);
    }
  }
}
