using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class AndInstructionTests {

    [Fact]
    public void Given_WhenGetInstructionKeyWord_ThenReturnAnd() {
      var result = new AndInstructionParser().GetInstructionKeyWord();
      Assert.Equal(result, "AND");
    }

    [Fact]
    public void GivenInstructionxANDyTod_WhenCreatingAndInstruction_ThenReturnCorrectInstruction() {
      Instruction andInstruction;
      new AndInstructionParser().TryParse("x AND y -> d", out andInstruction);
      Assert.Equal(andInstruction.CircuitGate, new AndGate());
      Assert.Equal(andInstruction.InputWires, new List<string>() { "x", "y" });
      Assert.Equal(andInstruction.OutputWire, "d");
    }
  }
}
