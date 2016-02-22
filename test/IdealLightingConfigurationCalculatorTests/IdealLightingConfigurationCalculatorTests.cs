using System.Collections.Generic;
using AdventOfCode.IdealLightingConfigurationCalculator;
using Xunit;

namespace test.IdealLightingConfigurationCalculatorTests {
  public class IdealLightingConfigurationCalculatorTests {
    private readonly IdealLightingConfigurationCalculator _sut;

    public IdealLightingConfigurationCalculatorTests() {
      _sut = new IdealLightingConfigurationCalculator();
    }

    [Fact]
    public void GivenInstructionTurnOn0x0Through999x999_WhenGetAmountOfSimpleLightingLights_ThenReturnOneMillion() {
      var lightingAll = InstructionFactory.GetInstruction("turn on 0,0 through 999,999");
      var result = _sut.GetAmountOfSimpleLightingLights(new List<Instruction> { lightingAll });
      Assert.Equal(result, 1000000);
    }

    [Fact]
    public void GivenInstructionToggle0x0Through999x0_WhenGetAmountOfSimpleLightingLights_ThenReturnOneThousand() {
      var lightingFirstRow = InstructionFactory.GetInstruction("toggle 0,0 through 999,0");
      var result = _sut.GetAmountOfSimpleLightingLights(new List<Instruction> { lightingFirstRow });
      Assert.Equal(result, 1000);
    }

    [Fact]
    public void GivenInstructionTurnOff499x499Through500x500_WhenGetAmountOfSimpleLightingLights_ThenReturnFour() {
      var lightingSome = InstructionFactory.GetInstruction("turn off 499,499 through 500,500");
      var result = _sut.GetAmountOfSimpleLightingLights(new List<Instruction> { lightingSome });
      Assert.Equal(result, 4);
    }

    [Fact]
    public void GivenInstructionTurnOn0x0Through0x0_WhenGetAmountOfTristateLightingLights_ThenReturnOne() {
      var lightingOne = InstructionFactory.GetInstruction("turn on 0,0 through 0,0");
      var result = _sut.GetAmountOfTristateLightingLights(new List<Instruction> { lightingOne });
      Assert.Equal(result, 1);
    }

    [Fact]
    public void GivenInstructionToggle0x0Through999x999_WhenGetAmountOfTristateLightingLights_ThenReturnTwoMillion() {
      var lightingAll = InstructionFactory.GetInstruction("toggle 0,0 through 999,999");
      var result = _sut.GetAmountOfTristateLightingLights(new List<Instruction> { lightingAll });
      Assert.Equal(result, 2000000);
    }
  }
}
