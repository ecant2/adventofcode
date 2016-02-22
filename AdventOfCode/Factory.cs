namespace AdventOfCode {
  interface Factory<out T> {
    T Get(string input);
  }
}
