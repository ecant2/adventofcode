using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace test {
  public class CircuitSignalCalculatorTests {

    private readonly CircuitSignalCalculator _sut;

    public CircuitSignalCalculatorTests() {
      _sut = new CircuitSignalCalculator();
      _sut.CreateCircuit(
        new List<Instruction>() {
          InstructionFactory.Instance.Get("123 -> x"),
          InstructionFactory.Instance.Get("456 -> y"),
          InstructionFactory.Instance.Get("x AND y -> d"),
          InstructionFactory.Instance.Get("x OR y -> e"),
          InstructionFactory.Instance.Get("x LSHIFT 2 -> f"),
          InstructionFactory.Instance.Get("y RSHIFT 2 -> g"),
          InstructionFactory.Instance.Get("NOT x -> h"),
          InstructionFactory.Instance.Get("NOT y -> i")
        });
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnD_ThenReturn72() {
      var signal = _sut.GetSignalOn("d");
      Assert.Equal(72, signal);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnE_ThenReturn507() {
      var signal = _sut.GetSignalOn("e");
      Assert.Equal(signal, 507);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnF_ThenReturn492() {
      var signal = _sut.GetSignalOn("f");
      Assert.Equal(signal, 492);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnG_ThenReturn114() {
      var signal = _sut.GetSignalOn("g");
      Assert.Equal(signal, 114);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnH_ThenReturn65412() {
      var signal = _sut.GetSignalOn("h");
      Assert.Equal(signal, 65412);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnI_ThenReturn65079() {
      var signal = _sut.GetSignalOn("i");
      Assert.Equal(signal, 65079);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnX_ThenReturn123() {
      var signal = _sut.GetSignalOn("x");
      Assert.Equal(signal, 123);
    }

    [Fact]
    public void GivenCreatedCircuit_WhenGetSignalOnY_ThenReturn456() {
      var signal = _sut.GetSignalOn("y");
      Assert.Equal(signal, 456);
    }
  }
}
