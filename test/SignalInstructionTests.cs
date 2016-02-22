using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class SignalInstructionTests {

    [Fact]
    public void GivenInstruction123Tox_WhenCreatingSignalInstruction_ThenReturnCorrectInstruction() {
      Instruction signalInstruction;
      new SignalInstructionParser().TryParse("123 -> x", out signalInstruction);
      Assert.Equal(signalInstruction.CircuitGate, new SignalGate());
      Assert.Equal(signalInstruction.InputWires, new List<string>() { "123" });
      Assert.Equal(signalInstruction.OutputWire, "x");
    }

    [Fact]
    public void GivenInstruction456Toy_WhenCreatingSignalInstruction_ThenReturnCorrectInstruction() {
      Instruction signalInstruction;
      new SignalInstructionParser().TryParse("456 -> y", out signalInstruction);
      Assert.Equal(signalInstruction.CircuitGate, new SignalGate());
      Assert.Equal(signalInstruction.InputWires, new List<string>() { "456" });
      Assert.Equal(signalInstruction.OutputWire, "y");
    }
  }
}
