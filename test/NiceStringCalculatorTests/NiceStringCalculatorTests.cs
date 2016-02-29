using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class NiceStringCalculatorTests {
    private readonly NiceStringCalculator _sut;

    public NiceStringCalculatorTests() {
      _sut = new NiceStringCalculator();
    }

    [Fact]
    public void GivenInputugknbfddgicrmopn_WhenGetNiceStringCount_ThenReturn1() {
      var result = _sut.GetNiceStringCount(new [] { "ugknbfddgicrmopn" });
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInputaaa_WhenGetNiceStringCount_ThenReturn1() {
      var result = _sut.GetNiceStringCount(new [] { "aaa" });
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInputjchzalrnumimnmhp_WhenGetNiceStringCount_ThenReturn1() {
      var result = _sut.GetNiceStringCount(new [] { "jchzalrnumimnmhp" });
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputhaegwjzuvuyypxyu_WhenGetNiceStringCount_ThenReturn0() {
      var result = _sut.GetNiceStringCount(new [] { "haegwjzuvuyypxyu" });
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenGetNiceStringCount_ThenReturn0() {
      var result = _sut.GetNiceStringCount(new [] { "dvszwmarrgswjxmb" });
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputqjhvhtzxzqqjkmpb_WhenGetNicerStringCount_ThenReturnTrue() {
      var result = _sut.GetNicerStringCount(new [] { "qjhvhtzxzqqjkmpb" });
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInputxxyxx_WhenGetNicerStringCount_ThenReturnTrue() {
      var result = _sut.GetNicerStringCount(new [] { "xxyxx" });
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInputuurcxstgmygtbstg_WhenGetNicerStringCount_ThenReturnFalse() {
      var result = _sut.GetNicerStringCount(new [] { "uurcxstgmygtbstg" });
      Assert.Equal(result, 0);
    }

    [Fact]
    public void GivenInputieodomkazucvgmuy_WhenGetNicerStringCount_ThenReturnFalse() {
      var result = _sut.GetNicerStringCount(new [] { "ieodomkazucvgmuy" });
      Assert.Equal(result, 0);
    }

  }
}
