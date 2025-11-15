using System;

namespace DesignPatterns.Patterns.Behavioral.Strategy;

public class ZipCompression : ICompressionStrategy
{
  public byte[] Compress(byte[] data)
  {
    Console.WriteLine("Compressing with Zip algorithm");
    using (MemoryStream outputMemoryStream = new MemoryStream())
    {
      
    }
    return data;
  }

  public byte[] Decompress(byte[] data)
  {
    Console.WriteLine("Decompressing with Zip algorithm");
    return data;
  }
}
