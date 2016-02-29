using System.Collections.Generic;
using AdventOfCode.DeliveryCalculator;
using Xunit;

namespace test.DeliveryCalculatorTests {
  public class NavigationProcessorTests {
    private NavigationProcessor _sut;
    private HashSet<Coordinates> _coordinatesSet;

    [Fact]
    public void GivenNoNavigation_WhenCreatingNavigationProcessor_thenCountIsOne() {
      _coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      _sut = new NavigationProcessor(new Navigation(), _coordinatesSet);

      Assert.Equal(_coordinatesSet.Count, 1);
    }

    [Fact]
    public void GivenSingleNavigation_WhenProcessNavigation_thenCountIsTwo() {
      _coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      _sut = new NavigationProcessor(new Navigation(), _coordinatesSet);

      _sut.ProcessNavigation('<');

      Assert.Equal(_coordinatesSet.Count, 2);
    }

    [Fact]
    public void GivenTwoOppositeNavigations_WhenProcessNavigation_thenCountIsTwo() {
      _coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      _sut = new NavigationProcessor(new Navigation(), _coordinatesSet);

      _sut.ProcessNavigation('<');
      _sut.ProcessNavigation('>');

      Assert.Equal(_coordinatesSet.Count, 2);
    }

    [Fact]
    public void GivenTwoNonOppositeNavigations_WhenProcessNavigation_thenCountIsThree() {
      _coordinatesSet = new HashSet<Coordinates> { new Coordinates(0, 0) };
      _sut = new NavigationProcessor(new Navigation(), _coordinatesSet);

      _sut.ProcessNavigation('<');
      _sut.ProcessNavigation('v');

      Assert.Equal(_coordinatesSet.Count, 3);
    }
  }
}
