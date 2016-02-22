namespace AdventOfCode {
  public class OrGate : BinaryGate {

    public override void SignalReceived(object sender) {
      if (First.Signal != null && Last.Signal != null) {
        Output.Signal = First.Signal | Last.Signal;
      }
    }
  }
}
