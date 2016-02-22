namespace AdventOfCode {

  public class LshiftGate : Gate {
    private int _numberOfBits;

    public LshiftGate(int numberOfBits) {
      _numberOfBits = numberOfBits;
    }

    public override void SignalReceived(object sender) {
      var signal = ((Wire)sender).Signal;
      if (signal != null) {
        Output.Signal = signal << _numberOfBits;
      }
    }

    public override void ConnectInput(Wire wire) {
      wire.SignalReceived += SignalReceived;
    }
  }
}
