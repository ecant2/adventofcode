using System;
using AdventOfCode.DeliveryCalculator;
using FluentAssertions;
using Xunit;

namespace test.DeliveryCalculatorTests {
  public class NavigationTests {
    [Fact]
    public void GivenCharUp_WhenGetNavigation_ThenReturnNorth() {
      var result = Navigation.GetNavigation('^');
      Assert.Equal(result, Navigation.North);
    }

    [Fact]
    public void GivenCharRight_WhenGetNavigation_ThenReturnEast() {
      var result = Navigation.GetNavigation('>');
      Assert.Equal(result, Navigation.East);
    }

    [Fact]
    public void GivenCharDown_WhenGetNavigation_ThenReturnSouth() {
      var result = Navigation.GetNavigation('v');
      Assert.Equal(result, Navigation.South);
    }

    [Fact]
    public void GivenCharLeft_WhenGetNavigation_ThenReturnWest() {
      var result = Navigation.GetNavigation('<');
      Assert.Equal(result, Navigation.West);
    }

    [Fact]
    public void GivenSomeChar_WhenGetNavigation_ThenThrowException() {
      Action getNavigation = () => Navigation.GetNavigation('§');
      getNavigation.ShouldThrow<ApplicationException>();
    }
  }
}
