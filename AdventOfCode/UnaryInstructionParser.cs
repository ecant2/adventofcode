using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public abstract class UnaryInstructionParser : InstructionParser {

    public UnaryInstructionParser() { }

    public abstract string GetInstructionKeyWord();

    public bool TryParse(string input, out Instruction instruction) {
      try {
        var parts = input.Split(new string[] {" -> "}, StringSplitOptions.None);
        var otherParts = parts[0].Split(new string[] {GetInstructionKeyWord()}, StringSplitOptions.None);
        if (parts.Length != 2 || otherParts.Length != 2)
          throw new ApplicationException();
        var numberOfBits = int.Parse(otherParts[1]);
        var result = parts[1].Trim();
        var value = otherParts[0].Trim();
        List<string> inputWires = new List<string> { value };
        instruction = new Instruction(inputWires, GateFactory.Instance.Get(GetInstructionKeyWord(), numberOfBits), result);
      }
      catch (Exception) {
        instruction = new Instruction();
        return false;
      }
      return true;
    }
  }
}
