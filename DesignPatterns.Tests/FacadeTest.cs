using System;
using DesignPatterns.Patterns.Structural.Facade;

namespace DesignPatterns.Tests;

public class FacadeTest
{
  [Fact]
  public void TestFacade()
  {
    HomeTheaterFacade theaterFacade = new();
    theaterFacade.WatchMovie("Spider-Man 2");
    theaterFacade.EndMovie();
  }
}
