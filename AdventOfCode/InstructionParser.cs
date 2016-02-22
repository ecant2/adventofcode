namespace AdventOfCode {
  public interface InstructionParser {
    bool TryParse(string input, out Instruction instruction);
  }
}
