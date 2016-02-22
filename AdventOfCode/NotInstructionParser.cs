using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class NotInstructionParser : InstructionParser {

    private const string _instructionKeyWord = "NOT";
    public Wire Value { get; }
    public Wire Result { get; }

    public NotInstructionParser() { }

    public NotInstructionParser(string value, string result) {
      Value = new Wire(value);
      Result = new Wire(result);
    }

    public NotInstructionParser(string input) {
    }

    public string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    public bool TryParse(string input, out Instruction instruction) {
      try {
        var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
        if (!parts[0].StartsWith(GetInstructionKeyWord()))
          throw new ApplicationException();
        var value = parts[0].Substring(4);
        var result = parts[1].Trim();
        List<string> inputWires = new List<string> { value };
        instruction = new Instruction(inputWires, GateFactory.Instance.Get(GetInstructionKeyWord()), result);
      } catch (Exception) {
        instruction = new Instruction();
        return false;
      }
      return true;
    }
  }
}
