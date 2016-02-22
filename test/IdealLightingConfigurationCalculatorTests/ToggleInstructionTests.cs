using AdventOfCode.IdealLightingConfigurationCalculator;
using Xunit;

namespace test.IdealLightingConfigurationCalculatorTests {
  public class ToggleInstructionTests {

    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnToggle() {
      var result = ToggleInstruction.GetInstructionKeyWord();
      Assert.Equal(result, "toggle");
    }

    [Fact]
    public void GivenInstructionToggle0x0Through999x999_WhenCreatingToggleInstruction_ThenReturn0x0x999x999() {
      var everything = new ToggleInstruction("toggle 0,0 through 999,999");
      Assert.Equal(everything.X1, 0);
      Assert.Equal(everything.Y1, 0);
      Assert.Equal(everything.X2, 999);
      Assert.Equal(everything.Y2, 999);
    }
  }
}
