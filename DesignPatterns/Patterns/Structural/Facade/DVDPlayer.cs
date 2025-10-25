using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class DVDPlayer : IPlayer
{
  public string InputType => "DVD";
  Movie _movie { get; set; } = new Movie();
  private bool PowerOn { get; set; } = false;
  private bool DiscTrayOpen { get; set; } = false;
  public void Pause()
  {
    _movie.State = MovieState.Pause;
    Console.WriteLine($"DVD Player: Paused '{_movie.Title}'");
  }

  public void Play(string movieTitle)
  {
    _movie = new Movie(movieTitle);
    _movie.State = MovieState.Play;
    Console.WriteLine($"DVD Player: Playing '{movieTitle}'");
  }

  public void Stop()
  {
    _movie.State = MovieState.Stop;
    Console.WriteLine($"DVD Player: Stopped '{_movie.Title}'");
  }

  public void DiscTrayToggle()
  {
    DiscTrayOpen = !DiscTrayOpen;
    Console.WriteLine($"DVD Player: Disc tray is now {(DiscTrayOpen ? "OPEN" : "CLOSED")}");
  }

  public void PowerToggle()
  {
    PowerOn = !PowerOn;
    Console.WriteLine($"DVD Player: Power is now {(PowerOn ? "ON" : "OFF")}");
  }
  public void On()
  {
    PowerOn = true;
  }
  public void Off()
  {
    PowerOn = false;
  }
}