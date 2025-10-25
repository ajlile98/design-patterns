using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public interface IPlayer
{
  string InputType { get; }
  public void Play(string movieTitle);
  public void Pause();
  public void Stop();
  public void On();
  public void Off();
}