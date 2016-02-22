using AdventOfCode.DeliveryCalculator;
using Xunit;

namespace test.DeliveryCalculatorTests {
  public class DeliveryCalculatorTests {
    private DeliveryCalculator _sut;

    public DeliveryCalculatorTests() {
      _sut = new DeliveryCalculator();
    }

    [Fact]
    public void GivenInputRight_WhenGetTotalDeliveries_ThenReturnTwo() {
      var result = _sut.GetTotalDeliveries(">");
      Assert.Equal(result, 2);
    }

    [Fact]
    public void voidGivenInputNorthEastSouthWest_WhenGetTotalDeliveries_ThenReturnFour() {
      var result = _sut.GetTotalDeliveries("^>v<");
      Assert.Equal(result, 4);
    }

    [Fact]
    public void voidGivenInputNorthSouthNorthSouthNorthSouthNorthSouthNorthSouth_WhenGetTotalDeliveries_ThenReturnTwo() {
      var result = _sut.GetTotalDeliveries("^v^v^v^v^v");
      Assert.Equal(result, 2);
    }

    [Fact]
    public void GivenInputRight_WhenGetTotalDeliveriesSpeededUp_ThenReturnThree() {
      var result = _sut.GetTotalDeliveriesSpeededUp("^v");
      Assert.Equal(result, 3);
    }

    [Fact]
    public void voidGivenInputNorthEastSouthWest_WhenGetTotalDeliveriesSpeededUp_ThenReturnThree() {
      var result = _sut.GetTotalDeliveriesSpeededUp("^>v<");
      Assert.Equal(result, 3);
    }


    [Fact]
    public void voidGivenInputNorthSouthNorthSouthNorthSouthNorthSouthNorthSouth_WhenGetTotalDeliveriesSpeededUp_ThenReturnEleven() {
      var result = _sut.GetTotalDeliveriesSpeededUp("^v^v^v^v^v");
      Assert.Equal(result, 11);
    }
  }
}
