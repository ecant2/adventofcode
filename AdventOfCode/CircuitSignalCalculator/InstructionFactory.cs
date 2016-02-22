using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class InstructionFactory : Factory<Instruction> {
    private readonly List<InstructionParser> _instructionParserList;

    public static InstructionFactory Instance { get; } = new InstructionFactory();

    private InstructionFactory() {
      _instructionParserList = new List<InstructionParser>();
      Register(new AndInstructionParser());
      Register(new OrInstructionParser());
      Register(new LshiftInstructionParser());
      Register(new RshiftInstructionParser());
      Register(new NotInstructionParser());
      Register(new SignalInstructionParser());
    }

    public void Register(InstructionParser instructionParser) {
      _instructionParserList.Add(instructionParser);
    }

    public Instruction Get(string input) {
      foreach (var instructionParser in _instructionParserList) {
        Instruction result;
        if (instructionParser.TryParse(input, out result))
          return result;
      }
      throw new ApplicationException("Unregisterd or incorrect instruction: " + input);
    }
  }
}
