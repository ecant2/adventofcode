using AdventOfCode.WrappingMaterialCalculator;
using Xunit;

namespace test.WrappingMaterialCalculatorTests {
  public class BoxTests {
    [Fact]
    public void GivenA5x4x2box_WhenGetTotalSurface_ThenReturn76() {
      var box = new Box(5, 4, 2);
      var result = box.GetTotalSurface();
      Assert.Equal(result, 76);
    }

    [Fact]
    public void GivenA5x4x2box_WhenGetSmallestSurface_ThenReturn8() {
      var box = new Box(5, 4, 2);
      var result = box.GetSmallestSurface();
      Assert.Equal(result, 8);
    }

    [Fact]
    public void GivenA5x4x2box_WhenGetSmallesPerimeter_ThenReturn12() {
      var box = new Box(5, 4, 2);
      var result = box.GetSmallesPerimeter();
      Assert.Equal(result, 12);
    }

    [Fact]
    public void GivenA5x4x2box_WhenGetVolume_ThenReturn40() {
      var box = new Box(5, 4, 2);
      var result = box.GetVolume();
      Assert.Equal(result, 40);
    }
  }
}
