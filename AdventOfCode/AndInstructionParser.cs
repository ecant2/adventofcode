namespace AdventOfCode {
  public class AndInstructionParser : BinaryInstructionParser {

    private const string _instructionKeyWord = "AND";

    public AndInstructionParser() : base() { }

    public override string GetInstructionKeyWord() {
      return _instructionKeyWord;
    }
  }
}
