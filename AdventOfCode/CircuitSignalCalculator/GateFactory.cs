using System;

namespace AdventOfCode {
  public class GateFactory : Factory<Gate> {

    public static GateFactory Instance { get; } = new GateFactory();

    private GateFactory() {}

    public Gate Get(string input) {
      if (input.Equals("AND"))
        return new AndGate();
      if (input.Equals("OR"))
        return new OrGate();
      if (input.Equals("NOT"))
        return new NotGate();
      if (input.Equals("PASS"))
        return new SignalGate();
      throw new ApplicationException("Incorrect Gate: " + input);
    }

    public Gate Get(string input, int numberOfBits) {
      if (input.Equals("LSHIFT"))
        return new LshiftGate(numberOfBits);
      if (input.Equals("RSHIFT"))
        return new RshiftGate(numberOfBits);
      throw new ApplicationException("Incorrect Gate: " + input);
    }
  }
}