using System.Collections.Generic;

namespace AdventOfCode {

  public class Instruction {

    public List<string> InputWires { get; }
    public Gate CircuitGate { get; }
    public string OutputWire { get; }

    public Instruction() { }

    public Instruction(List<string> inputWires, Gate circuitGate, string outputWire) {
      InputWires = inputWires;
      CircuitGate = circuitGate;
      OutputWire = outputWire;
    }

    protected bool Equals(Instruction other) {
      foreach (var otherWire in other.InputWires) {
        if (!InputWires.Contains(otherWire))
          return false;
      }
      return Equals(CircuitGate, other.CircuitGate) && Equals(OutputWire, other.OutputWire);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Instruction)obj);
    }

    public override int GetHashCode() {
      return InputWires.GetHashCode() ^ CircuitGate.GetHashCode() ^ OutputWire.GetHashCode();
    }
  }
}
