using System;
using System.IO.Compression;

namespace DesignPatterns.Patterns.Behavioral.Strategy;

public class GzipCompression : ICompressionStrategy
{
  public byte[] Compress(byte[] data)
  {
    Console.WriteLine("Compressing with GZIP algoritm");
    using var output = new MemoryStream();
    using var gzip = new GZipStream(output, CompressionMode.Compress);
    gzip.Write(data, 0, data.Length);
    gzip.Close();
    return output.ToArray();
  }

  public byte[] Decompress(byte[] data)
  {
    Console.WriteLine("Decompressing with GZIP algoritm");
    using var output = new MemoryStream();
    using var gzip = new GZipStream(output, CompressionMode.Decompress);
    gzip.Write(data, 0, data.Length);
    gzip.Close();
    return output.ToArray();
  }
}
