using System;

namespace DesignPatterns.Patterns.Behavioral.Strategy;

public class FileCompressor
{
  private ICompressionStrategy _strategy;

  public FileCompressor(ICompressionStrategy strategy)
  {
    _strategy = strategy;
  }

  public void SetStrategy(ICompressionStrategy strategy)
  {
    _strategy = strategy;
  }

  public byte[] Compress(byte[] data)
  {
    return _strategy.Compress(data);
  }

}
