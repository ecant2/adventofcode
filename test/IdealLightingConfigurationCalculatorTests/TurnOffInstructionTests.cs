using AdventOfCode.IdealLightingConfigurationCalculator;
using Xunit;

namespace test.IdealLightingConfigurationCalculatorTests {
  public class TurnOffInstructionTests {
    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnTurnOff() {
      var result = TurnOffInstruction.GetInstructionKeyWord();
      Assert.Equal(result, "turn off");
    }

    [Fact]
    public void GivenInstructionTurnOff0x0Through999x999_WhenCreatingTurnOffInstruction_ThenReturn0x0x999x999() {
      var everything = new TurnOffInstruction("turn off 0,0 through 999,999");
      Assert.Equal(everything.X1, 0);
      Assert.Equal(everything.Y1, 0);
      Assert.Equal(everything.X2, 999);
      Assert.Equal(everything.Y2, 999);
    }
  }
}
