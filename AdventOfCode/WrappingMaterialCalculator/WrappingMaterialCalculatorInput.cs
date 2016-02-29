using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.WrappingMaterialCalculator {
  public class WrappingMaterialCalculatorInput {

    private string Path { get; set; }
    private readonly List<Box> _input;

    public WrappingMaterialCalculatorInput(string path) {
      Path = path;
      _input = new List<Box>();
    }

    public List<Box> Transform() {
      if (_input.Count != 0) {
        try {
          using (var reader = new StreamReader(Path)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
              _input.Add(Transform(line));
            }
          }
        }
        catch (Exception) {
          throw new ApplicationException("Could not read the input file.");
        }
      }
      return _input;
    }

    private Box Transform(string input) {
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
