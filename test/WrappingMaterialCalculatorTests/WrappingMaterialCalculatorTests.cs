using System.Collections.Generic;
using AdventOfCode.WrappingMaterialCalculator;
using Xunit;

namespace test.WrappingMaterialCalculatorTests {
  public class WrappingMaterialCalculatorTests {

    private readonly WrappingMaterialCalculator _sut;

    public WrappingMaterialCalculatorTests() {
      _sut = new WrappingMaterialCalculator();
    }

    [Fact]
    public void GivenDimensionOfTwoThreeFour_WhenGetTotalSquareFeetWrappingPaper_ThenReturnFiftyEight() {
      var result = _sut.GetTotalSquareFeetWrappingPaper(new List<Box>() { new Box(2, 3, 4) });
      Assert.Equal(result, 58);
    }

    [Fact]
    public void GivenDimensionOfOneOneTen_WhenGetTotalSquareFeetWrappingPaper_ThenReturnFourtyThree() {
      var result = _sut.GetTotalSquareFeetWrappingPaper(new List<Box>() { new Box(1, 1, 10) });
      Assert.Equal(result, 43);
    }

    [Fact]
    public void GivenDimensionOfTwoThreeFourAndDimensionOfOneOneTen_WhenGetTotalSquareFeetWrappingPaper_ThenReturnFiftyEight() {
      var result = _sut.GetTotalSquareFeetWrappingPaper(new List<Box>() { new Box(2, 3, 4), new Box(1, 1, 10) });
      Assert.Equal(result, 101);
    }

    [Fact]
    public void GivenDimensionOfTwoThreeFour_WhenGetTotalFeetRibbon_thenReturnThirtyFour() {
      var result = _sut.GetTotalFeetRibbon(new List<Box>() { new Box(2, 3, 4) });
      Assert.Equal(result, 34);
    }

    [Fact]
    public void GivenDimensionOfOneOneTen_WhenGetTotalSquareFeetWrappingPaper_ThenReturnFourteen() {
      var result = _sut.GetTotalFeetRibbon(new List<Box>() { new Box(1, 1, 10) });
      Assert.Equal(result, 14);
    }

    [Fact]
    public void GivenDimensionOfTwoThreeFourAndDimensionOfOneOneTen_WhenGetTotalSquareFeetWrappingPaper_ThenReturnFourtEight() {
      var result = _sut.GetTotalFeetRibbon(new List<Box>() { new Box(2, 3, 4), new Box(1, 1, 10) });
      Assert.Equal(result, 48);
    }
  }
}
