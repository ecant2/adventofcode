using System;

namespace AdventOfCode {
  public class Wire {

    public string Identifier { get; }

    private int? _siganal;

    public int? Signal {
      get { return _siganal; }
      set { if (value != _siganal) { _siganal = value; OnSignalReceived(); } }
    }

    public Wire(string identifier) {
      Identifier = identifier;
    }

    private bool Equals(Wire other) {
      return string.Equals(Identifier, other.Identifier);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Wire)obj);
    }

    public override int GetHashCode() {
      return Identifier.GetHashCode();
    }

    public class SignalReceivedEventArgs : EventArgs {

      public SignalReceivedEventArgs(Wire wire) {
        Wire = wire;
      }

      public Wire Wire { get; }
    }

    public event SignalReceivedEventHandler SignalReceived;

    public delegate void SignalReceivedEventHandler(object sender);

    protected virtual void OnSignalReceived() {
      SignalReceivedEventHandler handler = SignalReceived;
      handler?.Invoke(this);
    }
  }
}