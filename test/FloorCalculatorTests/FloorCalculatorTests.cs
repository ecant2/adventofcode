using AdventOfCode.FloorCalculator;
using Xunit;

namespace test.FloorCalculatorTests {
  public class FloorCalculatorTests {

    private readonly FloorCalculator _sut;

    public FloorCalculatorTests() {
      _sut = new FloorCalculator(new SingularMove());
    }

    [Fact]
    public void GivenInputUpUpDownDown_WhenGetFinalFloorPosition_ThenReturnZero() {
      var result = _sut.GetFinalFloorPosition("(())");
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputUpDownUpDown_WhenGetFinalFloorPosition_ThenReturnZero() {
      var result = _sut.GetFinalFloorPosition("()()");
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputUpUpUp_WhenGetFinalFloorPosition_ThenReturnThree() {
      var result = _sut.GetFinalFloorPosition("(((");
      Assert.Equal(result, 3);
    }

    [Fact]
    public void GivenInputUpUpDownUpUpDownUp_WhenGetFinalFloorPosition_ThenReturnThree() {
      var result = _sut.GetFinalFloorPosition("(()(()(");
      Assert.Equal(result, 3);
    }

    [Fact]
    public void GivenInputDownDownUpUpUpUpUp_WhenGetFinalFloorPosition_ThenReturnThree() {
      var result = _sut.GetFinalFloorPosition("))(((((");
      Assert.Equal(result, 3);
    }

    [Fact]
    public void GivenInputUpDownDown_WhenGetFinalFloorPosition_ThenReturnMinusOne() {
      var result = _sut.GetFinalFloorPosition("())");
      Assert.Equal(result, -1);
    }

    [Fact]
    public void GivenInputDownDownUp_WhenGetFinalFloorPosition_ThenReturnMinusOne() {
      var result = _sut.GetFinalFloorPosition("))(");
      Assert.Equal(result, -1);
    }

    [Fact]
    public void GivenInputDownDownDown_WhenGetFinalFloorPosition_ThenReturnMinusThree() {
      var result = _sut.GetFinalFloorPosition(")))");
      Assert.Equal(result, -3);
    }

    [Fact]
    public void GivenInputDownUpDownDownUpDownDown_WhenGetFinalFloorPosition_ThenReturnMinusThree() {
      var result = _sut.GetFinalFloorPosition(")())())");
      Assert.Equal(result, -3);
    }

    [Fact]
    public void GivenInputDown_WhenGetFirstMoveThatCausesEnteringBasement_ThenReturnOne() {
      var result = _sut.GetFirstMoveThatCausesEnteringBasement(")");
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInputUpDownUpDownDown_WhenGetFirstMoveThatCausesEnteringBasement_ThenReturnFive() {
      var result = _sut.GetFirstMoveThatCausesEnteringBasement("()())");
      Assert.Equal(result, 5);
    }
  }
}
