using System.Collections.Generic;
using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class MinimalVowelCountPropertyTests {

    private readonly MinimalVowelCountProperty _sut;

    public MinimalVowelCountPropertyTests() {
      _sut = new MinimalVowelCountProperty(new List<char>("aeiou".ToCharArray()), 3);
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
    public void GivenInputjchzalrnumimnmhp_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("jchzalrnumimnmhp");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputhaegwjzuvuyypxyu_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("haegwjzuvuyypxyu");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.DoesSatisfy("dvszwmarrgswjxmb");
      Assert.Equal(result, false);
    }
  }
}
