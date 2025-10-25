using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class Screen
{
  public bool IsDown { get; set; } = false;

  public void Down()
  {
    IsDown = true;
    Console.WriteLine("Screen: Lowering DOWN");
  }

  public void Up()
  {
    IsDown = false;
    Console.WriteLine("Screen: Raising UP");
  }
}
