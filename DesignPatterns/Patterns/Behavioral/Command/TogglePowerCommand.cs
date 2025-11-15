using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class TogglePowerCommand(Television tv) : ICommand
{
    public void Execute()
    {
        tv.TogglePower();
    }
}
