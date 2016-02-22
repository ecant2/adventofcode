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

    public void PassSignals() {
      foreach (var wire in _wires.Values) {
        int _siganl;
        if (int.TryParse(wire.Identifier, out _siganl))
          wire.Signal = _siganl;
      }      
    }

    public void ClearSignals() {
      foreach (var wire in _wires.Values) {
        wire.Signal = null;
      }
    }
  }
}
