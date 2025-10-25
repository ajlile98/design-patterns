using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class Movie(string Title = "")
{
  public string Title { get; set; } = Title;
  public MovieState State { get; set; } = MovieState.Stop;
}

public enum MovieState
{
  Play,
  Pause,
  Stop,
}