using AdventOfCode.MD5HashesCalculator;
using Xunit;

namespace test.MD5HashesCalculatorTests {
  public class MD5HashesCalculatorTests {

    private readonly MD5HashesCalculator _sut;

    public MD5HashesCalculatorTests() {
      _sut = new MD5HashesCalculator();
    }

    [Fact]
    public void GivenInputabcdef_WhenGetSecretKeySuffixForCorrectHash_ThenReturn609043() {
      var result = _sut.GetSuffixForSecretKeyResultingInHashWithLeadingZeros("abcdef", 5);
      Assert.Equal(result, 609043);
    }

    [Fact]
    public void GivenInputpqrstuv_WhenGetSecretKeySuffixForCorrectHash_ThenReturn1048970() {
      var result = _sut.GetSuffixForSecretKeyResultingInHashWithLeadingZeros("pqrstuv", 5);
      Assert.Equal(result, 1048970);
    }
  }
}
