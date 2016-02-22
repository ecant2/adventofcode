using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.MD5HashesCalculator {
  public class MD5HashesCalculator {

    private readonly MD5 _md5;
    private readonly StringBuilder _sb;

    public MD5HashesCalculator() {
      _md5 = MD5.Create();
      _sb = new StringBuilder();
    }

    public int GetSuffixForSecretKeyResultingInHashWithLeadingZeros(string secretKey, int numberOfLeadingZeros) {
      var leadingZeros = string.Concat(Enumerable.Repeat('0', numberOfLeadingZeros));
      var suffix = 0;
      while (!ConvertTohexadecimal(CreateHash(secretKey + suffix++)).StartsWith(leadingZeros)) {}
      return --suffix;
    }

    private byte[] CreateHash(string input) {
      var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
      return _md5.ComputeHash(inputBytes);
    }

    private string ConvertTohexadecimal(byte[] hash) {
      _sb.Clear();
      foreach (byte t in hash) {
        _sb.Append(t.ToString("X2"));
      }
      return _sb.ToString();
    }
  }
}