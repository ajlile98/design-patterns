using System;
using System.Text;
using DesignPatterns.Patterns.Behavioral.Strategy;

namespace DesignPatterns.Tests;

public class StrategyTest
{
  [Fact]
  public void TestStrategy()
  {
    string text = "Hello world";
    byte[] data = Encoding.UTF8.GetBytes(text);
    var compressor = new FileCompressor(new GzipCompression());
    byte[] compressed = compressor.Compress(data);
    Console.WriteLine(Encoding.UTF8.GetString(compressed));

    compressor.SetStrategy(new ZipCompression());
    byte[] compressed2 = compressor.Compress(data);
    Console.WriteLine(Encoding.UTF8.GetString(compressed2));


  }
}
