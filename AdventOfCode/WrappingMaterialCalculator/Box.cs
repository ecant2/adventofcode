using System;
using System.Threading;

namespace AdventOfCode.WrappingMaterialCalculator {
  public class Box {

    private readonly int _length;
    private readonly int _width;
    private readonly int _height;

    public Box(int length, int width, int height) {
      _length = length;
      _width = width;
      _height = height;
    }

    public int GetTotalSurface() {
      return 2 * GetFrontSurface() + 2 * GetSideSurface() + 2 * GetTopSurface();
    }

    public int GetSmallestSurface() {
      return Math.Min(Math.Min(GetFrontSurface(), GetSideSurface()), GetTopSurface());
    }
    public int GetSmallesPerimeter() {
      return Math.Min(Math.Min(GetFrontPerimeter(), GetSidePerimeter()), GetTopPerimeter());
    }

    public int GetVolume() {
      return _length * _width * _height;
    }

    private int GetFrontSurface() {
      return _length*_width;
    }

    private int GetSideSurface() {
      return _width * _height;
    }

    private int GetTopSurface() {
      return _height * _length;
    }

    private int GetFrontPerimeter() {
      return 2 * _length + 2 * _width;
    }

    private int GetSidePerimeter() {
      return 2 * _width + 2 * _height;
    }

    private int GetTopPerimeter() {
      return 2 * _height + 2 * _length;
    }
  }
}