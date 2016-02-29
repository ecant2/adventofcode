using System;

namespace AdventOfCode.FloorCalculator {

  public class Move {

    public static readonly Move Up = new Move(1, '(');
    public static readonly Move Down = new Move(-1, ')');

    public int Value { get; }
    public char Representation { get; }

    public Move() {}

    private Move(int value, char representation) {
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
