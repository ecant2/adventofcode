using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DeliveryCalculator {
  public class NavigationProcessor {

    private readonly HashSet<Coordinates> _coordinatesSet;
    private Coordinates _current;

    public NavigationProcessor(HashSet<Coordinates> coordinatesSet) {
      _coordinatesSet = coordinatesSet;
      _current = coordinatesSet.First();
    }

    public void ProcessNavigation(char input) {
      var navigationCoordinates = Navigation.GetNavigation(input).Value;
      _current = _current.Add(navigationCoordinates);
      _coordinatesSet.Add(_current);
    }
  }
}

