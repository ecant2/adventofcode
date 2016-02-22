using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode {
  class MultiLineInput<T> {
    private readonly List<T> _input;

    public MultiLineInput(string path, Factory<T> factory) {
      _input = new List<T>();
      try {
        using (var reader = new StreamReader(path)) {
          string line;
          while ((line = reader.ReadLine()) != null) {
            _input.Add(factory.Get(line));
          }
        }
      } catch (Exception) {
        throw new ApplicationException("Could not read the input file.");
      }
    }

    public List<T> GetInput() {
      return _input;
    }
  }
}
