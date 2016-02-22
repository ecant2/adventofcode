using System.Collections.Generic;

namespace AdventOfCode {
  public class WireManager {

    private Dictionary<string, Wire> _wires = new Dictionary<string, Wire>();

    public static WireManager Instance { get; } = new WireManager();

    private WireManager() {}

    public Wire GetWire(string wireIdentifier) {
      if (!_wires.ContainsKey(wireIdentifier))
        _wires[wireIdentifier] = new Wire(wireIdentifier);
      return _wires[wireIdentifier];
    }
  }
}
