using System;

namespace DesignPatterns.Patterns.Behavioral.Strategy;

public class LzwCompression : ICompressionStrategy
{
  public byte[] Compress(byte[] data)
  {
    Console.WriteLine("Compressing with Lzw algorithm");
    return data;
  }

  public byte[] Decompress(byte[] data)
  {
    Console.WriteLine("Decompressing with Lzw algorithm");
    return data;
  }
}
