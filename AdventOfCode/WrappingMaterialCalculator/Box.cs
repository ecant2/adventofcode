using System;

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

    public int TotalSurface() {
      return 2 * FrontSurface() + 2 * SideSurface() + 2 * TopSurface();
    }

    public int SmallestSurface() {
      return Math.Min(Math.Min(FrontSurface(), SideSurface()), TopSurface());
    }

    public int SmallesPerimeter() {
      return Math.Min(Math.Min(FrontPerimeter(), SidePerimeter()), TopPerimeter());
    }

    public int Volume() {
      return _length * _width * _height;
    }

    private int FrontSurface() {
      return _length*_width;
    }

    private int SideSurface() {
      return _width * _height;
    }

    private int TopSurface() {
      return _height * _length;
    }

    private int FrontPerimeter() {
      return 2 * _length + 2 * _width;
    }

    private int SidePerimeter() {
      return 2 * _width + 2 * _height;
    }

    private int TopPerimeter() {
      return 2 * _height + 2 * _length;
    }
  }
}