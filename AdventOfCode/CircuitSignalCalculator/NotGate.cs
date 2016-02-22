using System;

namespace AdventOfCode {
  public class NotGate : Gate {
    public override void SignalReceived(object sender) {
      var signal = ((Wire) sender).Signal;
      if (signal != null) {
        var orig = Convert.ToString((int) signal, 2).PadLeft(16, '0');
        var complement = orig.Replace('0', '2').Replace('1', '0').Replace('2', '1');
        Output.Signal = Convert.ToInt32(complement, 2);
      }
    }

    public override void ConnectInput(Wire wire) {
      wire.SignalReceived += SignalReceived;
    }
  }
}
