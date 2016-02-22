using System.Collections.Generic;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public class IdealLightingConfigurationCalculator {

    public int GetAmountOfSimpleLightingLights(List<Instruction> instructions) {
      bool[,] lights = new bool[1000, 1000];
      foreach (var instruction in instructions) {
        instruction.ExecuteOn(lights);
      }
      return CountLightingLights(lights);
    }

    public int GetAmountOfTristateLightingLights(List<Instruction> instructions) {
      int[,] lights = new int[1000, 1000];
      foreach (var instruction in instructions) {
        instruction.ExecuteOn(lights);
      }
      return CountLightingLights(lights);
    }

    private int CountLightingLights(bool[,] lights) {
      var result = 0;
      for (int row = 0; row < 1000; row++) {
        for (int column = 0; column < 1000; column++) {
          if (lights[row, column])
            result++;
        }
      }
      return result;
    }

    private int CountLightingLights(int[,] lights) {
      var result = 0;
      for (int row = 0; row < 1000; row++) {
        for (int column = 0; column < 1000; column++) {
            result += lights[row, column];
        }
      }
      return result;
    }
  }
}
