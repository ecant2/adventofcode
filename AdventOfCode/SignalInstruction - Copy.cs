using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class SignalInstruction : Instruction {

    public Wire Value { get; }
    public Wire Result { get; }

    public SignalInstruction(string result, int signal) {
      Value = null;
      Result = new Wire(result) { Signal = signal };
    }

    public SignalInstruction(string input) {
      var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
      Result = WireManager.Instance.GetWire(parts[1].Trim());
      int signal;
      if (int.TryParse(parts[0], out signal)) {
        Result.Signal = signal;
        Value = null;
      } else {
        Value = WireManager.Instance.GetWire(parts[0].Trim());
        Value.SignalReceived += SignalReceived;
      }
    }

    public SignalInstruction() {
    }

    public bool TryParse(string input, out Instruction result) {
      result = null;
      try {
        result = new SignalInstruction(input);
        return true;
      } catch (Exception) {
        return false;
      }
    }

    public void Execute() {
      if (Value != null) {
        Result.Signal = Value.Signal;
      }
    }

    public void SignalReceived(object sender) {
      Execute();
    }

    protected bool Equals(SignalInstruction other) {
      return Equals(Value, other.Value) && Equals(Result, other.Result);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignalInstruction)obj);
    }

    public override int GetHashCode() {
      return Value.GetHashCode() ^ Result.GetHashCode();
    }
    public override string ToString() {
      string signal = Result.Signal != null ? Result.Signal.ToString() : "null";
      return "Siganl: " + (Value != null ? Value.Identifier : signal) + " -> " + Result.Identifier;
    }
  }
}
