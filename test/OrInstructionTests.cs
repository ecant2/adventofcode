using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class OrInstructionTests {
    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnOr() {
      var result = new OrInstructionParser().GetInstructionKeyWord();
      Assert.Equal(result, "OR");
    }

    [Fact]
    public void GivenInstructionxORyTOe_WhenCreatingOrInstruction_ThenReturnCorrectInstruction() {
      Instruction orInstruction;
      new OrInstructionParser().TryParse("x OR y -> e", out orInstruction);
      Assert.Equal(orInstruction.CircuitGate, new OrGate());
      Assert.Equal(orInstruction.InputWires, new List<string>() { "x", "y" });
      Assert.Equal(orInstruction.OutputWire, "e");
    }
  }
}
