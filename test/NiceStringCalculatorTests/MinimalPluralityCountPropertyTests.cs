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
      var result = _sut.DoesSatisfy("ugknbfddgicrmopn");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputaaa_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("aaa");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputjchzalrnumimnmhp_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.DoesSatisfy("jchzalrnumimnmhp");
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenInputhaegwjzuvuyypxyu_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("haegwjzuvuyypxyu");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("dvszwmarrgswjxmb");
      Assert.Equal(result, true);
    }
  }
}
