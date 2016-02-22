using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.WrappingMaterialCalculator {
  public class WrappingMaterialCalculatorInput {

    private readonly List<Box> _input;

    public WrappingMaterialCalculatorInput(string path) {
      _input = new List<Box>();
      try {
        using (var reader = new StreamReader(path)) {
          string line;
          while ((line = reader.ReadLine()) != null) {
            _input.Add(TransformInput(line));
          }
        }
      }
      catch (Exception) {
        throw new ApplicationException("Could not read the input file.");
      }
    }

    public List<Box> GetInput() {
      return _input;
    }

    private static Box TransformInput(string input) {
      var parts = input.Split('x');
      if (parts.Length != 3) {
        throw new ApplicationException("Input was not in a correct format.");
      }
      try {
        var l = int.Parse(parts[0]);
        var w = int.Parse(parts[1]);
        var h = int.Parse(parts[2]);
        return new Box(l, w, h);
      } catch (Exception) {
        throw new ApplicationException("Input contains non-numerical data.");
      }
    }
  }
}
