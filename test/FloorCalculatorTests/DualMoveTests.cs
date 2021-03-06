﻿using System;
using AdventOfCode.FloorCalculator;
using FluentAssertions;
using Xunit;

namespace test.FloorCalculatorTests {
  public class DualMoveTests {
    private DualMove _sut;

    public DualMoveTests() {
      _sut = new DualMove();
    }

    public void GivenCharOpenParenthesis_WhenGetMove_ThenReturnUp() {
      var result = _sut.ToMove('{');
      Assert.Equal(result, _sut.Up);
    }

    [Fact]
    public void GivenCharClosedParenthesis_WhenGetMove_ThenReturnDown() {
      var result = _sut.ToMove('}');
      Assert.Equal(result, _sut.Down);
    }

    [Fact]
    public void GivenSomeChar_WhenGetMove_ThenThrowException() {
      Action move = () => _sut.ToMove('§');
      move.ShouldThrow<ApplicationException>();
    }
  }
}
