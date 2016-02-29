using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode {
  class MultiLineInput<T> {
    private readonly string _path;
    private readonly Factory<T> _factory;
    private readonly List<T> _input;

    public MultiLineInput(string path, Factory<T> factory) {
      _path = path;
      _factory = factory;
      _input = new List<T>();
    }

    public List<T> Transform() {
      if (_input.Count == 0) {
        try {
          using (var reader = new StreamReader(_path)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
              _input.Add(_factory.Get(line));
            }
          }
        } catch (Exception) {
          throw new ApplicationException("Could not read the input file.");
        }
      }
      return _input;
    }
  }
}
