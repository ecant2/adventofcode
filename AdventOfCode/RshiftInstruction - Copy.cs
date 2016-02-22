using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class RshiftInstruction : UnaryInstruction {

    private const string _instructionKeyWord = "RSHIFT";

    public RshiftInstruction() : base() { }

    public RshiftInstruction(int numberOfBits, string value, string result) : base(numberOfBits, value, result) { }

    public RshiftInstruction(string input) : base(input) { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public override bool TryParse(string input, out Instruction result) {
      result = null;
      try {
        result = new RshiftInstruction(input);
        return true;
      } catch (Exception) {
        return false;
      }
    }

    public override void Execute() {
      if (Value.Signal != null) {
        Result.Signal = Value.Signal >> NumberOfBits;
      }
    }
  }
}
