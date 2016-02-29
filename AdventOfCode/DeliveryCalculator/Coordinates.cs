namespace AdventOfCode.DeliveryCalculator {
  public class Coordinates {

    private readonly int _x;
    private readonly int _y;

    public Coordinates(int x, int y) {
      _x = x;
      _y = y;
    }

    public Coordinates Add(Coordinates navigation) {
      return new Coordinates(_x + navigation._x, _y + navigation._y);
    }

    protected bool Equals(Coordinates other) {
      return _x == other._x && _y == other._y;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Coordinates)obj);
    }

    public override int GetHashCode() {
      return _x.GetHashCode() ^ _y.GetHashCode();
    }
  }
}