using System;

namespace AdventOfCode.FloorCalculator {
  public class DualMove : Move {

    private static readonly Move DualUp = new DualMove(2, '{');
    private static readonly Move DualDown = new DualMove(-2, '}');

    public Move Up { get; } = DualUp;
    public Move Down { get; } = DualDown;
    public int Value { get; }
    public char Representation { get; }

    public DualMove() {}

    private DualMove(int value, char representation) {
      Value = value;
      Representation = representation;
    }

    public Move ToMove(char representation) {
      if (Up.Representation.Equals(representation))
        return Up;
      if (Down.Representation.Equals(representation))
        return Down;
      throw new ApplicationException("Wrong representation for a Move: " + representation.ToString());
    }
  }
}