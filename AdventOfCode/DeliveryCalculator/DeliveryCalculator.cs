using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.DeliveryCalculator {
  public class DeliveryCalculator {

    public int GetTotalDeliveries(string input) {
      var coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      var navigationProcessor = new NavigationProcessor(new Navigation(), coordinatesSet);
      foreach (var c in input) {
        navigationProcessor.ProcessNavigation(c);
      }
      return coordinatesSet.Count;
    }

    public int GetTotalDeliveriesSpeededUp(string input) {
      var coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      var firstProcessor = new NavigationProcessor(new Navigation(), coordinatesSet);
      var lastProcessor = new NavigationProcessor(new Navigation(), coordinatesSet);
      for (var i = 0; i < input.Length; i+=2) {
        firstProcessor.ProcessNavigation(input.ElementAt(i));
        if (i + 1 < input.Length) {
          lastProcessor.ProcessNavigation(input.ElementAt(i + 1));
        }
      }
      return coordinatesSet.Count;
    }
  }
}
