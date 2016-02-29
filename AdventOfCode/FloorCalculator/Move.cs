namespace AdventOfCode.FloorCalculator {
  public interface Move {

    Move Up { get; }
    Move Down { get; }
    int Value { get; }
    char Representation { get; }

    Move ToMove(char representation);
  }
}
