using System.Linq;

namespace AdventOfCode.FloorCalculator {
  public class FloorCalculator {
    private readonly Move _moveRules;

    private const int Basement = -1;

    public FloorCalculator(Move moveRules) {
      _moveRules = moveRules;
    }

    public int GetFinalFloorPositionEx(string input) {
      return GetMoveUpCount(input) - GetMoveDownCount(input);
    }

    public int GetFinalFloorPosition(string input) {
      return input.Select(c => _moveRules.ToMove(c)).Sum(m => m.Value);
    }

    public int GetFirstMoveThatCausesEnteringBasementEx(string input) {
      var result = 1;
      while (GetFinalFloorPosition(input.Substring(0, result)) != Basement) {
        result++;
      }
      return result;
    }

    public int GetFirstMoveThatCausesEnteringBasement(string input) {
      var result = 0;
      var floor = 0;

      while (floor != Basement) {
        floor = AddMoveToFloor(_moveRules.ToMove(input.ElementAt(result++)), floor);
      }
      return result;
    }

    private int GetMoveDownCount(string input) {
      return input.Count(x => x == _moveRules.Down.Representation);
    }

    private int GetMoveUpCount(string input) {
      return input.Count(x => x == _moveRules.Up.Representation);
    }

    private int AddMoveToFloor(Move move, int floor) {
      return floor + move.Value;
    }
  }
}
