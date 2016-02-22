namespace AdventOfCode {
  public interface Instruction {
    bool TryParse(string input, out Instruction result);
    void Execute();
    void SignalReceived(object sender);
  }
}
