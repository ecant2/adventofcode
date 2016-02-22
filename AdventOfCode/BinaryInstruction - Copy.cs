
using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public abstract class BinaryInstruction : Instruction {

    public Wire First { get; }
    public Wire Last { get; }
    public Wire Result { get; }

    public BinaryInstruction() { }

    public BinaryInstruction(string first, string last, string result) {
      First = new Wire(first);
      Last = new Wire(last);
      Result = new Wire(result);
    }

    public BinaryInstruction(string input) {
      var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
      var otherParts = parts[0].Split(new string[] { GetInstructionKeyWord() }, StringSplitOptions.None);
      if (parts.Length != 2 || otherParts.Length != 2)
        throw new ApplicationException();
      Result = WireManager.Instance.GetWire(parts[1].Trim());
      First = WireManager.Instance.GetWire(otherParts[0].Trim());
      Last = WireManager.Instance.GetWire(otherParts[1].Trim());
      First.SignalReceived += SignalReceived;
      Last.SignalReceived += SignalReceived;
      int signal;
      if (int.TryParse(otherParts[0], out signal)) {
        First.Signal = signal;
      }
      Last = WireManager.Instance.GetWire(otherParts[1].Trim());
      if (int.TryParse(otherParts[1], out signal)) {
        Last.Signal = signal;
      }
    }

    public abstract string GetInstructionKeyWord();

    protected bool Equals(BinaryInstruction other) {
      return Equals(First, other.First) && Equals(Last, other.Last) && Equals(Result, other.Result);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BinaryInstruction)obj);
    }

    public override int GetHashCode() {
      return First.GetHashCode() ^ Last.GetHashCode() ^ Result.GetHashCode();
    }

    public abstract bool TryParse(string input, out Instruction result);

    public abstract void Execute();

    public void SignalReceived(object sender) {
      Execute();
    }

    public override string ToString() {
      return First.Identifier + " " + GetInstructionKeyWord() + " " + Last.Identifier + " -> " + Result.Identifier;
    }
  }
}
