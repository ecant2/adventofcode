using System;
using AdventOfCode.DeliveryCalculator;
using FluentAssertions;
using Xunit;

namespace test.DeliveryCalculatorTests {
  public class NavigationTests {
    private Navigation _sut;

    public NavigationTests() {
      _sut = new Navigation();
    }

    [Fact]
    public void GivenCharUp_WhenGetNavigation_ThenReturnNorth() {
      var result = _sut.ToNavigation('^');
      Assert.Equal(result, Navigation.North);
    }

    [Fact]
    public void GivenCharRight_WhenGetNavigation_ThenReturnEast() {
      var result = _sut.ToNavigation('>');
      Assert.Equal(result, Navigation.East);
    }

    [Fact]
    public void GivenCharDown_WhenGetNavigation_ThenReturnSouth() {
      var result = _sut.ToNavigation('v');
      Assert.Equal(result, Navigation.South);
    }

    [Fact]
    public void GivenCharLeft_WhenGetNavigation_ThenReturnWest() {
      var result = _sut.ToNavigation('<');
      Assert.Equal(result, Navigation.West);
    }

    [Fact]
    public void GivenSomeChar_WhenGetNavigation_ThenThrowException() {
      Action getNavigation = () => _sut.ToNavigation('§');
      getNavigation.ShouldThrow<ApplicationException>();
    }
  }
}
