using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class LshiftInstructionTests {
    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnLshift() {
      var result = new LshiftInstructionParser().GetInstructionKeyWord();
      Assert.Equal(result, "LSHIFT");
    }

    [Fact]
    public void GivenInstructionxLSHIFT2TOf_WhenCreatingLshiftInstruction_ThenReturnCorrectInstruction() {
      Instruction lshiftInstruction;
      new LshiftInstructionParser().TryParse("x LSHIFT 2 -> f", out lshiftInstruction);
      Assert.Equal(lshiftInstruction.CircuitGate, new LshiftGate(2));
      Assert.Equal(lshiftInstruction.InputWires, new List<string>() { "x" });
      Assert.Equal(lshiftInstruction.OutputWire, "f");
    }
  }
}
