using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.MD5HashesCalculator {
  public class MD5HashesCalculator {

    private readonly MD5 _md5;

    public MD5HashesCalculator() {
      _md5 = MD5.Create();
    }

    public int GetSuffixForSecretKeyResultingInHashWithLeadingZeros(string secretKey, int numberOfLeadingZeros) {
      var leadingZeros = string.Concat(Enumerable.Repeat('0', numberOfLeadingZeros));
      var suffix = 0;
      var convert = ConvertToHexadecimal(CreateHash(secretKey + suffix++));
      while (!convert.StartsWith(leadingZeros)) {
        convert = ConvertToHexadecimal(CreateHash(secretKey + suffix++));
      }
      return --suffix;
    }

    private byte[] CreateHash(string input) {
      var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
      return _md5.ComputeHash(inputBytes);
    }

    private string ConvertToHexadecimal(byte[] hash) {
      var sb = new StringBuilder();
      foreach (byte t in hash) {
        sb.Append(t.ToString("X2"));
      }
      return sb.ToString();
    }
  }
}