using System;
using AdventOfCode.FloorCalculator;
using FluentAssertions;
using Xunit;

namespace test.FloorCalculatorTests {
  public class Tests {
    public void GivenCharOpenParenthesis_WhenGetMove_ThenReturnUp() {
      var result = Move.GetMove('(');
      Assert.Equal(result, Move.Up);
    }

    [Fact]
    public void GivenCharClosedParenthesis_WhenGetMove_ThenReturnDown() {
      var result = Move.GetMove(')');
      Assert.Equal(result, Move.Down);
    }

    [Fact]
    public void GivenSomeChar_WhenGetMove_ThenThrowException() {
      Action move = () => Move.GetMove('§');
      move.ShouldThrow<ApplicationException>();
    }
  }
}