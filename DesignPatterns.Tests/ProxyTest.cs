using System;
using DesignPatterns.Patterns.Structural.Proxy;

namespace DesignPatterns.Tests;

public class ProxyTest
{
  [Fact]
  public void TestProxy()
  {
    IImage image = new ImageProxy("myImage.jpg");
    Console.WriteLine("ImageProxy was created. Now Displaying()");

    image.Display();
    Console.WriteLine($"Image Dimensions: {image.GetDimensions()}");
    image.Display();
  }

}
