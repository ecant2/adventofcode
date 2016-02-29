using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.WrappingMaterialCalculator {
  public class WrappingMaterialCalculator {
    public int GetTotalSquareFeetWrappingPaper(List<Box> boxes) {
      return boxes.Sum(box => box.TotalSurface() + box.SmallestSurface());
    }

    public int GetTotalFeetRibbon(List<Box> boxes) {
      return boxes.Sum(box => box.SmallesPerimeter() + box.Volume());
    }
  }
}
