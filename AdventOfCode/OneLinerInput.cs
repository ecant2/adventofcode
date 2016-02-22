using System;
using System.IO;

namespace AdventOfCode {
  public class OneLinerInput {
    public static string GetInput(string path) {
      try {
        using (var reader = new StreamReader(path)) {
          return reader.ReadToEnd();
        }
      } catch (Exception) {
        throw new ApplicationException("Could not read the input file.");
      }
    }
  }
}