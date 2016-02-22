using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class InstructionFactoryTests {

    private readonly InstructionFactory _sut;

    public InstructionFactoryTests() {
      _sut = InstructionFactory.Instance;
    }

    [Fact]
    public void GivenInput123ToX_WhenGet_ThenReturnCorrectSignalInstruction() {
      var instruction = _sut.Get("123 -> x");
      Assert.Equal(instruction, new Instruction(new List<string>() { "123" }, new SignalGate(), "x"));
    }

    [Fact]
    public void GivenInput456ToY_WhenGet_ThenReturnCorrectSignalInstruction() {
      var instruction = _sut.Get("456 -> y");
      Assert.Equal(instruction, new Instruction(new List<string>() { "456" }, new SignalGate(), "y"));
    }

    [Fact]
    public void GivenInputxANDyTOd_WhenGet_ThenReturnCorrectAndInstruction() {
      var instruction = _sut.Get("x AND y -> d");
      Assert.Equal(instruction, new Instruction(new List<string>() { "x", "y" }, new AndGate(), "d"));
    }

    [Fact]
    public void GivenInputxORyTOe_WhenGet_ThenReturnCorrectOrInstruction() {
      var instruction = _sut.Get("x OR y -> e");
      Assert.Equal(instruction, new Instruction(new List<string>() { "x", "y" }, new OrGate(), "e"));
    }

    [Fact]
    public void GivenInputxLSHIFT2TOf_WhenGet_ThenReturnCorrectLshiftInstruction() {
      var instruction = _sut.Get("x LSHIFT 2 -> f");
      Assert.Equal(instruction, new Instruction(new List<string>() { "x" }, new LshiftGate(2), "f"));
    }

    [Fact]
    public void GivenInputyRSHIFT2TOg_WhenGet_ThenReturnCorrectRshiftInstruction() {
      var instruction = _sut.Get("y RSHIFT 2 -> g");
      Assert.Equal(instruction, new Instruction(new List<string>() { "y" }, new RshiftGate(2), "g"));
    }

    [Fact]
    public void GivenInputNOTxTOh_WhenGet_ThenReturnCorrectNotInstruction() {
      var instruction = _sut.Get("NOT x -> h");
      Assert.Equal(instruction, new Instruction(new List<string>() { "x" }, new NotGate(), "h"));
    }

    [Fact]
    public void GivenInputNOTyTOi_WhenGet_ThenReturnCorrectNotInstruction() {
      var instruction = _sut.Get("NOT y -> i");
      Assert.Equal(instruction, new Instruction(new List<string>() { "y" }, new NotGate(), "i"));
    }
  }
}
