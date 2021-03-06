﻿using AdventOfCode.NiceStringCalculator;
using Xunit;

namespace test.NiceStringCalculatorTests {
  public class RepetitionOnNextPlacePropertyTests {
    private readonly RepetitionOnNextPlaceProperty _sut;

    public RepetitionOnNextPlacePropertyTests() {
      _sut = new RepetitionOnNextPlaceProperty(1, 2);
    }

    [Fact]
    public void GivenInputqjhvhtzxzqqjkmpb_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("qjhvhtzxzqqjkmpb");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputxxyxx_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("xxyxx");
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenInputuurcxstgmygtbstg_WhenDoesSatisfy_ThenReturnFalse() {
      var result = _sut.Satisfies("uurcxstgmygtbstg");
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenInputieodomkazucvgmuy_WhenDoesSatisfy_ThenReturnTrue() {
      var result = _sut.Satisfies("ieodomkazucvgmuy");
      Assert.Equal(result, true);
    }
  }
}
