using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class NotInstructionTests {
    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnNot() {
      var result = new NotInstructionParser().GetInstructionKeyWord();
      Assert.Equal(result, "NOT");
    }

    [Fact]
    public void GivenInstructionNOTxTOh_WhenCreatingNotInstruction_ThenReturnCorrectInstruction() {
      Instruction notInstruction;
      new NotInstructionParser().TryParse("NOT x -> h", out notInstruction);
      Assert.Equal(notInstruction.CircuitGate, new NotGate());
      Assert.Equal(notInstruction.InputWires, new List<string>() {"x"});
      Assert.Equal(notInstruction.OutputWire, "h");
    }

    [Fact]
    public void GivenInstructionNOTyTOi_WhenCreatingNotInstruction_ThenReturnCorrectInstruction() {
      Instruction notInstruction;
      new NotInstructionParser().TryParse("NOT y -> i", out notInstruction);
      Assert.Equal(notInstruction.CircuitGate, new NotGate());
      Assert.Equal(notInstruction.InputWires, new List<string>() { "y" });
      Assert.Equal(notInstruction.OutputWire, "i");
    }
  }
}
