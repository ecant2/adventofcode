using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class RshiftInstructionTests {
    public void Given_WhenGetInstructionKeyWord_ThenReturnRshift() {
      var result = new LshiftInstructionParser().GetInstructionKeyWord();
      Assert.Equal(result, "RSHIFT");
    }

    [Fact]
    public void GivenInstructionyRSHIFT2TOg_WhenCreatingRshiftInstruction_ThenReturnCorrectInstruction() {
      Instruction rshiftInstruction;
      new RshiftInstructionParser().TryParse("y RSHIFT 2 -> g", out rshiftInstruction);
      Assert.Equal(rshiftInstruction.CircuitGate, new RshiftGate(2));
      Assert.Equal(rshiftInstruction.InputWires, new List<string>() { "y" });
      Assert.Equal(rshiftInstruction.OutputWire, "g");
    }
  }
}
