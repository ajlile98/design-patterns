using System;
using Microsoft.VisualBasic;

namespace DesignPatterns.Patterns.Structural.Adapter;

public class Mp3PlayerAdapter() : IMediaPlayer
{
  Mp3Player player = new Mp3Player();
  public void PlayMedia()
  {
    player.PlayMp3();
  }

}
