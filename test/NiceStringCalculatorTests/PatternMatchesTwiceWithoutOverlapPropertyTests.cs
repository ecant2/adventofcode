using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class PatternMatchesTwiceWithoutOverlapPropertyTests {
    private readonly PatternMatchesTwiceWithoutOverlapProperty _sut;

    public PatternMatchesTwiceWithoutOverlapPropertyTests() {
      _sut = new PatternMatchesTwiceWithoutOverlapProperty(2);
    }

    [Fact]
    public void GivenInputqjhvhtzxzqqjkmpb_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("qjhvhtzxzqqjkmpb");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputxxyxx_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("xxyxx");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputuurcxstgmygtbstg_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("uurcxstgmygtbstg");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputieodomkazucvgmuy_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.DoesSatisfy("ieodomkazucvgmuy");
      Assert.Equal(result, false);
    }
  }
}
