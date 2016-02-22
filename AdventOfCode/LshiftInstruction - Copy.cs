using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class LshiftInstruction : UnaryInstruction {

    private const string _instructionKeyWord = "LSHIFT";

    public LshiftInstruction() : base() { }

    public LshiftInstruction(int numberOfBits, string value, string result) : base(numberOfBits, value, result) { }

    public LshiftInstruction(string input) : base(input) { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public override bool TryParse(string input, out Instruction result) {
      result = null;
      try {
        result = new LshiftInstruction(input);
        return true;
      } catch (Exception) {
        return false;
      }
    }

    public override void Execute() {
      if (Value.Signal != null) {
        Result.Signal = Value.Signal << NumberOfBits;
      }
    }
  }
}
