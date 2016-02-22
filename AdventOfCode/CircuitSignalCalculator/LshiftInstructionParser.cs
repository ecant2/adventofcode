using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class LshiftInstructionParser : UnaryInstructionParser {

    private const string _instructionKeyWord = "LSHIFT";

    public LshiftInstructionParser() : base() { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }
  }
}
