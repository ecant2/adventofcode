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
        if (counter == 83) {
          Console.WriteLine("stop");
        }
        instruction.CircuitGate.ConnectOutput(WireManager.Instance.GetWire(instruction.OutputWire));
        foreach (var wire in instruction.InputWires) {
          instruction.CircuitGate.ConnectInput(WireManager.Instance.GetWire(wire));
        }
      }
      WireManager.Instance.PassSignals();
    }

    public void SetSignalOn(string wireIdentifier, int? signal) {
      WireManager.Instance.GetWire(wireIdentifier).Signal = signal;
    }
  }
}
