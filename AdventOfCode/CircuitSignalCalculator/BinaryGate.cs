using System;

namespace AdventOfCode {
  public abstract class BinaryGate : Gate {

    public Wire First { get; set; }

    public Wire Last { get; set; }

    public override void ConnectInput(Wire wire) {
      if (First == null) {
        First = wire;
      } else {
        Last = wire;
      }
      wire.SignalReceived += SignalReceived;
    }

    protected bool Equals(BinaryGate other) {
      return Equals(First, other.First) && Equals(Last, other.Last) && Equals(Output, other.Output);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BinaryGate)obj);
    }

    public override int GetHashCode() {
      return First.GetHashCode() ^ Last.GetHashCode() ^ Output.GetHashCode();
    }
  }
}
