using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DeliveryCalculator {
  public class NavigationProcessor {

    private readonly Navigation _navigationRules;
    private readonly HashSet<Coordinates> _coordinatesSet;
    private Coordinates _current;

    public NavigationProcessor(Navigation navigationRules, HashSet<Coordinates> coordinatesSet) {
      _navigationRules = navigationRules;
      _coordinatesSet = coordinatesSet;
      _current = coordinatesSet.First();
    }

    public void ProcessNavigation(char input) {
      var navigationCoordinates = _navigationRules.ToNavigation(input).Value;
      _current = _current.Add(navigationCoordinates);
      _coordinatesSet.Add(_current);
    }
  }
}

