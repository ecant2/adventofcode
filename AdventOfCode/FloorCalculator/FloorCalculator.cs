using System.Linq;

namespace AdventOfCode.FloorCalculator {
  public class FloorCalculator {
    private readonly Move _moveRules;

    private const int Basement = -1;

    public FloorCalculator(Move moveRules) {
      _moveRules = moveRules;
    }

    public int GetFinalFloorPosition(string input) {
      return GetMoveUpCount(input) - GetMoveDownCount(input);
    }

    public int GetFirstMoveThatCausesEnteringBasementEx(string input) {
      var result = 1;
      while (GetFinalFloorPosition(input.Substring(0, result)) != Basement) {
        result++;
      }
      return result;
    }

    public int GetFirstMoveThatCausesEnteringBasement(string input) {
      return input.Select(c => _moveRules.ToMove(c)).Sum(m => m.Value);
    }

    private static int GetMoveDownCount(string input) {
      return input.Count(x => x == Move.Down.Representation);
    }

    private static int GetMoveUpCount(string input) {
      return input.Count(x => x == Move.Up.Representation);
    }

    private static int AddMoveToFloor(Move move, int floor) {
      return floor + move.Value;
    }
  }
}
