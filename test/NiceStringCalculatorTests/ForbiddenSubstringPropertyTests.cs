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
    public void GivenInputugknbfddgicrmopn_WhenSatisfies_ThenReturnTrue() {
      var result = _sut.Satisfies("ugknbfddgicrmopn");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputaaa_WhenSatisfies_ThenReturnTrue() {
      var result = _sut.Satisfies("aaa");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputjchzalrnumimnmhp_WhenSatisfies_ThenReturnTrue() {
      var result = _sut.Satisfies("jchzalrnumimnmhp");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputhaegwjzuvuyypxyu_WhenSatisfies_ThenReturnFalse() {
      var result = _sut.Satisfies("haegwjzuvuyypxyu");
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenInputdvszwmarrgswjxmb_WhenSatisfies_ThenReturnTrue() {
      var result = _sut.Satisfies("dvszwmarrgswjxmb");
      Assert.Equal(result, true);
    }
  }
}
