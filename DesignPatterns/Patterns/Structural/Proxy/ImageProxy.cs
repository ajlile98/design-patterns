using System;

namespace DesignPatterns.Patterns.Structural.Proxy;

public class ImageProxy(string _FilePath): IImage
{
  RealImage _image = null!;

  public string FilePath => _FilePath;

  public void Display()
  {
    if (_image is null)
    {
      _image = new RealImage(FilePath);
    }
    _image.Display();
  }

  public ImageDimensions GetDimensions()
  {
    if(_image is null)
    {
      _image = new RealImage(FilePath);
    }
    return _image.GetDimensions();
  }
}
