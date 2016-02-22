using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class CircuitSignalCalculator {

    public int? GetSignalOn(string wireIdentifier) {
      return WireManager.Instance.GetWire(wireIdentifier).Signal;
    }

    public void CreateCircuit(List<Instruction> input) {
      int counter = 0;
      foreach (var instruction in input) {
        Console.WriteLine("*******************************" + counter++ + " " + instruction + "*************************");
        instruction.Execute();
      }
    }
  }
}
