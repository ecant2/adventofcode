﻿namespace AdventOfCode {
  public class AndGate : BinaryGate {

    public override void SignalReceived(object sender) {
      if (First.Signal != null && Last.Signal != null) {
        Output.Signal = First.Signal & Last.Signal;
      }
    }
  }
}
