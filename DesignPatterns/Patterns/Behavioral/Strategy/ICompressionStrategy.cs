using System;

namespace DesignPatterns.Patterns.Behavioral.Strategy;

public interface ICompressionStrategy
{
  byte[] Compress(byte[] data);
  byte[] Decompress(byte[] data);
}
