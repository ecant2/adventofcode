using System;
using System.Collections.Generic;

namespace AdventOfCode {
  public class NotInstruction : Instruction {

    private const string _instructionKeyWord = "NOT";
    public Wire Value { get; }
    public Wire Result { get; }

    public NotInstruction() { }

    public NotInstruction(string value, string result) {
      Value = new Wire(value);
      Result = new Wire(result);
    }

    public NotInstruction(string input) {
      var parts = input.Split(new string[] { " -> " }, StringSplitOptions.None);
      if (!parts[0].StartsWith(GetInstructionKeyWord()))
        throw new ApplicationException();
      Value = WireManager.Instance.GetWire(parts[0].Substring(4));
      Result = WireManager.Instance.GetWire(parts[1].Trim());
      Value.SignalReceived += SignalReceived;
    }

    public string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }

    protected bool Equals(NotInstruction other) {
      return Equals(Value, other.Value) && Equals(Result, other.Result);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((NotInstruction)obj);
    }

    public override int GetHashCode() {
      return Value.GetHashCode() ^ Result.GetHashCode();
    }

    public bool TryParse(string input, out Instruction result) {
      result = null;
      try {
        result = new NotInstruction(input);
        return true;
      } catch (Exception) {
        return false;
      }
    }

    public void Execute() {
      if (Value.Signal != null) {
        var orig = Convert.ToString((int)Value.Signal, 2).PadLeft(16, '0');
        var complement = orig.Replace('0', '2').Replace('1', '0').Replace('2', '1');
        Result.Signal = Convert.ToInt32(complement, 2);
      }
    }

    public void SignalReceived(object sender) {
      Execute();
    }

    public override string ToString() {
      return _instructionKeyWord + " " + Value.Identifier + " -> " + Result.Identifier;
    }
  }
}
