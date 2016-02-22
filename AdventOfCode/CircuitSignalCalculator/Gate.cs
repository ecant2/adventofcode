namespace AdventOfCode {
  public abstract class Gate {

    public Wire Output { get; set; }

    public abstract void SignalReceived(object sender);

    public abstract void ConnectInput(Wire wire);

    public void ConnectOutput(Wire wire) {
      Output = wire;
    }

    protected bool Equals(Gate other) {
      return Equals(Output, other.Output);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Gate)obj);
    }

    public override int GetHashCode() {
      return Output.GetHashCode();
    }
  }
}
