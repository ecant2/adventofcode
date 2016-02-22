namespace AdventOfCode {
  public class RshiftInstructionParser : UnaryInstructionParser {

    private const string _instructionKeyWord = "RSHIFT";

    public RshiftInstructionParser() : base() { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }
  }
}
