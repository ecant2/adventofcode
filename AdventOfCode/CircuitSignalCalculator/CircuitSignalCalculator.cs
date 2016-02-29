using System.Collections.Generic;

namespace AdventOfCode {
  public class CircuitSignalCalculator {

    public int? GetSignalOn(string wireIdentifier) {
      return WireManager.Instance.GetWire(wireIdentifier).Signal;
    }

    public void CreateCircuit(List<Instruction> input) {
      foreach (var instruction in input) {
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
