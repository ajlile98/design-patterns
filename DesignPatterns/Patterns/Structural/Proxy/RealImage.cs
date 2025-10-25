using System;

namespace DesignPatterns.Patterns.Structural.Proxy;

public class RealImage : IImage
{
  private string _filePath;
  public string FilePath => _filePath;
  public ImageDimensions Dimensions {get; set;}

  public RealImage(string filePath)
  {
    _filePath = filePath;
    Console.WriteLine($"Loading image from disk {filePath}");
    Dimensions = new ImageDimensions(10, 10);
  }

  public void Display()
  {
    Console.WriteLine($"Displaying Image: {FilePath}");
  }

  public ImageDimensions GetDimensions()
  {
    return Dimensions;
  }
}
