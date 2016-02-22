using AdventOfCode.DeliveryCalculator;
using Xunit;

namespace test.DeliveryCalculatorTests {
  public class CoordinatesTests {

    private readonly Coordinates _sut;

    public CoordinatesTests() {
      _sut = new Coordinates(0, 0);
    }

    [Fact]
    public void GivenThisCoordinates_WhenEquals_ThenReturnTrue() {
      var result = _sut.Equals(_sut);
      Assert.Equal(result, true);
    }

    [Fact]
    public void GivenNullCoordinates_WhenEquals_ThenReturnFalse() {
      Coordinates current = null;
      var result = _sut.Equals(current);
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenSomeObject_WhenEquals_ThenReturnFalse() {
      var someObject = new object();
      var result = _sut.Equals(someObject);
      Assert.Equal(result, false);
    }

    [Fact]
    public void GivenSomeCoordinates_WhenEquals_ThenReturnFalse() {
      var result = _sut.Equals(new Coordinates(5, 9));
      Assert.Equal(result, false);
    }
  }
}
