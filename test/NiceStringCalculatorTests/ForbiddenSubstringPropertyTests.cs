using System.Collections.Generic;
using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class ForbiddenSubstringPropertyTests {

    private readonly ForbiddenSubstringProperty _sut;

    public ForbiddenSubstringPropertyTests() {
      _sut = new ForbiddenSubstringProperty(new List<string>() { "ab", "cd", "pq", "xy" });
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
    public void GivenInputhaegwjzuvuyypxyu_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.DoesSatisfy("haegwjzuvuyypxyu");
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.DoesSatisfy("dvszwmarrgswjxmb");
      Assert.Equal(result, true);
    }
  }
}
