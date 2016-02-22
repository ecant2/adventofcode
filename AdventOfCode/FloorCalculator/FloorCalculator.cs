using System.Linq;

namespace AdventOfCode.FloorCalculator {
  public class FloorCalculator {

    private const int Basement = -1;

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
      var result = 0;
      var floor = 0;

      while (floor != Basement) {
        floor = AddMoveToFloor(Move.GetMove(input.ElementAt(result++)), floor);
      }
      return result;
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
