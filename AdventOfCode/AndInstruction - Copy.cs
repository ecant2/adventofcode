using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class AndInstruction : BinaryInstruction {

    private const string _instructionKeyWord = "AND";

    public AndInstruction() : base() { }

    public AndInstruction(string first, string last, string result) : base(first, last, result) { }

    public AndInstruction(string input) : base(input) { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public override bool TryParse(string input, out Instruction result) {
      result = null;
      try {
        result = new AndInstruction(input);
        return true;
      } catch (Exception) {
        return false;
      }
    }

    public override void Execute() {
      if (First.Signal != null && Last.Signal != null) {
        Result.Signal = First.Signal & Last.Signal;
      }
    }
  }
}
