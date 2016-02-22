using System;

namespace AdventOfCode.IdealLightingConfigurationCalculator {
  public abstract class Instruction {

    public int X1 { get; }
    public int Y1 { get; }
    public int X2 { get; }
    public int Y2 { get; }

    public Instruction(string input, int lengh) {
      var parts = input.Remove(0, lengh).Split(new string[] { " through " }, StringSplitOptions.None);
      var firstPart = parts[0];
      var xFirstPart = firstPart.Split(',')[0];
      var yFirstPart = firstPart.Split(',')[1];
      X1 = Convert.ToInt32(xFirstPart);
      Y1 = Convert.ToInt32(yFirstPart);
      var lastPart = parts[1];
      var xLastPart = lastPart.Split(',')[0];
      var yLastPart = lastPart.Split(',')[1];
      X2 = Convert.ToInt32(xLastPart);
      Y2 = Convert.ToInt32(yLastPart);
    }

    abstract public void ExecuteOn(bool[,] lights);

    abstract public void ExecuteOn(int[,] lights);
  }
}