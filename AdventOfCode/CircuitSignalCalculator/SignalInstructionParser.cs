using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class SignalInstructionParser : InstructionParser {

    public Wire Value { get; }
    public Wire Result { get; }

    public SignalInstructionParser(string result, int signal) {
      Value = null;
      Result = new Wire(result) { Signal = signal };
    }

    public SignalInstructionParser(string input) {
    }

    public SignalInstructionParser() {
    }

    public bool TryParse(string input, out Instruction instruction) {
      try {
        var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
        var result = parts[1].Trim();
        var value = parts[0].Trim();
        List<string> inputWires = new List<string> { value };
        instruction = new Instruction(inputWires, GateFactory.Instance.Get("PASS"), result);
      } catch (Exception) {
        instruction = new Instruction();
        return false;
      }
      return true;
    }
  }
}
