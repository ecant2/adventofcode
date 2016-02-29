using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.NiceStringCalculator {
  internal class PropertyManager {

    private readonly List<Property> _allProperties;

    public PropertyManager() {
      _allProperties = new List<Property>();
    }

    public void Add(Property property) {
      _allProperties.Add(property);
    }

    public bool Satisfies(string input) {
      return _allProperties.Aggregate(true, (current, property) => current & property.Satisfies(input));
    }
  }
}
