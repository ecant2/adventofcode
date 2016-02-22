using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.WrappingMaterialCalculator {
  public class WrappingMaterialCalculator {
    public int GetTotalSquareFeetWrappingPaper(List<Box> boxes) {
      return boxes.Sum(box => box.GetTotalSurface() + box.GetSmallestSurface());
    }

    public int GetTotalFeetRibbon(List<Box> boxes) {
      return boxes.Sum(box => box.GetSmallesPerimeter() + box.GetVolume());
    }
  }
}
