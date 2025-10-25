using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class HomeTheaterFacade(IPlayer? player = null)
{
  protected Lights lights = new();
  protected Screen screen = new();
  protected Projector projector = new();
  protected Amplifier amplifier = new();
  protected IPlayer player = player ?? new DVDPlayer();
  public void WatchMovie(string movieTitle)
  {
    Console.WriteLine($"Start Watching Movie {movieTitle}");

    // Lights
    lights.Dim(10);
    // Screen
    screen.Down();
    // Projector
    projector.On();
    projector.SetInput(player.InputType);
    projector.SetWideScreenMode();
    // Amplifier
    amplifier.On();
    amplifier.SetSurroundSound();
    amplifier.Volume = 5;
    // DVD Player
    player.On();
    player.Play(movieTitle);

  }
  public void EndMovie()
  {
    Console.WriteLine("Ending Movie");

    // Player
    player.Stop();
    player.Off();
    // Amplifier
    amplifier.Off();
    // Projector
    projector.Off();
    // Screen
    screen.Up();
    // Lights
    lights.On();
  }
}
