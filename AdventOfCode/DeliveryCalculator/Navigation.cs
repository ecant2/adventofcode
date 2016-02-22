using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.DeliveryCalculator {
  public class Navigation {
    public static readonly Navigation North = new Navigation(new Coordinates(0, 1), '^');
    public static readonly Navigation East = new Navigation(new Coordinates(1, 0), '>');
    public static readonly Navigation South = new Navigation(new Coordinates(0, -1), 'v');
    public static readonly Navigation West = new Navigation(new Coordinates(-1, 0), '<');

    public Coordinates Value { get; }
    public char Representation { get; }

    public Navigation(Coordinates value, char representation) {
      Value = value;
      Representation = representation;
    }

    public static Navigation GetNavigation(char representation) {
      if (North.Representation.Equals(representation))
        return North;
      else if (East.Representation.Equals(representation))
        return East;
      else if (South.Representation.Equals(representation))
        return South;
      else if (West.Representation.Equals(representation))
        return West;
      else
        throw new ApplicationException("Wrong representation for a Navigation: " + representation.ToString());
    }
  }
}
