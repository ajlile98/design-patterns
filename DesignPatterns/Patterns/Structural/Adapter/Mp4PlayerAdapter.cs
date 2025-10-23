using System;

namespace DesignPatterns.Patterns.Structural.Adapter;

public class Mp4PlayerAdapter : Mp4Player, IMediaPlayer
{
  public void PlayMedia()
  {
    PlayMp4();
  }
}
