
using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public abstract class BinaryInstructionParser : InstructionParser {

    public BinaryInstructionParser() { }

    public abstract string GetInstructionKeyWord();

    public bool TryParse(string input, out Instruction instruction) {
      try {
        var parts = input.Split(new string[] {" -> "}, StringSplitOptions.None);
        var otherParts = parts[0].Split(new string[] {GetInstructionKeyWord()}, StringSplitOptions.None);
        var result = parts[1].Trim();
        var first = otherParts[0].Trim();
        var last = otherParts[1].Trim();
        List<string> inputWire = new List<string> { first, last };
        instruction = new Instruction(inputWire, GateFactory.Instance.Get(GetInstructionKeyWord()), result);
      } catch (Exception) {
        instruction = new Instruction();
        return false;
      }
      return true;
    }
  }
}
