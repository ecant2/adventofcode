using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class InstructionFactory : Factory<Instruction> {
    private readonly List<Instruction> _instructionList;

    public static InstructionFactory Instance { get; } = new InstructionFactory();

    private InstructionFactory() {
      _instructionList = new List<Instruction>();
      Register(new AndInstruction());
      Register(new OrInstruction());
      Register(new LshiftInstruction());
      Register(new RshiftInstruction());
      Register(new NotInstruction());
      Register(new SignalInstruction());
    }

    public void Register(Instruction instruction) {
      _instructionList.Add(instruction);
    }

    public Instruction Get(string input) {
      foreach (var instruction in _instructionList) {
        Instruction result;
        if (instruction.TryParse(input, out result))
          return result;
      }
      throw new ApplicationException("Unregisterd or incorrect instruction: " + input);
    }
  }
}
