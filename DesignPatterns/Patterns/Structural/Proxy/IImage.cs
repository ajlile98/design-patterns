using System;

namespace DesignPatterns.Patterns.Structural.Proxy;

public interface IImage
{
  string FilePath { get; }
  public void Display();
  public ImageDimensions GetDimensions();
}

public record ImageDimensions(int height, int width);