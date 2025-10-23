using System;
using DesignPatterns.Patterns.Structural.Adapter;

namespace DesignPatterns.Tests;

public class AdapterTest
{
  [Fact]
  public void TestMp3Adapter()
  {
    IMediaPlayer player = new Mp3PlayerAdapter();
    player.PlayMedia();
  }
  [Fact]
  public void TestMp4Adapter()
  {
    IMediaPlayer player = new Mp4PlayerAdapter();
    player.PlayMedia();
  }
}
