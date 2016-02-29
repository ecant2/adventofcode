using System;
using AdventOfCode.FloorCalculator;
using FluentAssertions;
using Xunit;

namespace test.FloorCalculatorTests {
  public class Tests {
    private Move _sut;

    public Tests() {
      _sut = new Move();
    }

    public void GivenCharOpenParenthesis_WhenGetMove_ThenReturnUp() {
      var result = _sut.ToMove('(');
      Assert.Equal(result, Move.Up);
    }

    [Fact]
    public void GivenCharClosedParenthesis_WhenGetMove_ThenReturnDown() {
      var result = _sut.ToMove(')');
      Assert.Equal(result, Move.Down);
    }

    [Fact]
    public void GivenSomeChar_WhenGetMove_ThenThrowException() {
      Action move = () => _sut.ToMove('§');
      move.ShouldThrow<ApplicationException>();
    }
  }
}