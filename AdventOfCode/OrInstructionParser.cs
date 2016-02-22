using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class OrInstructionParser : BinaryInstructionParser {

    private const string _instructionKeyWord = "OR";

    public OrInstructionParser() : base() { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }
  }
}
