using AdventOfCode.IdealLightingConfigurationCalculator;
using Xunit;

namespace test.IdealLightingConfigurationCalculatorTests {
  public class TurnOnInstructionTests {
    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnTurnOn() {
      var result = TurnOnInstruction.GetInstructionKeyWord();
      Assert.Equal(result, "turn on");
    }

    [Fact]
    public void GivenInstructionTurnOn0x0Through999x999_WhenCreatingTurnOnInstruction_ThenReturn0x0x999x999() {
      var everything = new TurnOnInstruction("turn on 0,0 through 999,999");
      Assert.Equal(everything.X1, 0);
      Assert.Equal(everything.Y1, 0);
      Assert.Equal(everything.X2, 999);
      Assert.Equal(everything.Y2, 999);
    }
  }
}
