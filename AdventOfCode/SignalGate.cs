using System;

namespace AdventOfCode {
  public class SignalGate : Gate {
    public override void SignalReceived(object sender) {
      Output.Signal = ((Wire) sender).Signal;
    }

    public override void ConnectInput(Wire wire) {
      wire.SignalReceived += SignalReceived;
    }
  }
}
