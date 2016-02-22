using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public abstract class UnaryInstruction : Instruction {

    public int NumberOfBits { get; }
    public Wire Value { get; }
    public Wire Result { get; }

    public UnaryInstruction() { }

    public UnaryInstruction(int numberOfBits, string value, string result) {
      NumberOfBits = numberOfBits;
      Value = new Wire(value);
      Result = new Wire(result);
    }

    public UnaryInstruction(string input) {
      var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
      var otherParts = parts[0].Split(new string[] { GetInstructionKeyWord() }, StringSplitOptions.None);
      if (parts.Length != 2 || otherParts.Length != 2)
        throw new ApplicationException();
      NumberOfBits = int.Parse(otherParts[1]);
      Result = WireManager.Instance.GetWire(parts[1].Trim());
      Value = WireManager.Instance.GetWire(otherParts[0].Trim());
      Value.SignalReceived += SignalReceived;
    }

    public abstract string GetInstructionKeyWord();

    protected bool Equals(UnaryInstruction other) {
      return Equals(Value, other.Value) && NumberOfBits == other.NumberOfBits && Equals(Result, other.Result);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((UnaryInstruction)obj);
    }

    public override int GetHashCode() {
      return Value.GetHashCode() ^ NumberOfBits ^ Result.GetHashCode();
    }

    public abstract bool TryParse(string input, out Instruction result);

    public abstract void Execute();

    public void SignalReceived(object sender) {
      Execute();
    }

    public override string ToString() {
      return Value.Identifier + " " + GetInstructionKeyWord() + " " + NumberOfBits + " -> " + Result.Identifier;
    }
  }
}
