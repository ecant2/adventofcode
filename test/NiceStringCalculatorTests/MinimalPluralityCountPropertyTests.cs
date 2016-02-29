using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class MinimalPluralityCountPropertyTests {

    private readonly MinimalPluralityCountProperty _sut;

    public MinimalPluralityCountPropertyTests() {
      _sut = new MinimalPluralityCountProperty(2, 1);
    }

    [Fact]
    public void GivenInputugknbfddgicrmopn_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("ugknbfddgicrmopn");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputaaa_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("aaa");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputjchzalrnumimnmhp_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.Satisfies("jchzalrnumimnmhp");
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenInputhaegwjzuvuyypxyu_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("haegwjzuvuyypxyu");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("dvszwmarrgswjxmb");
      Assert.Equal(result, true);
    }
  }
}
