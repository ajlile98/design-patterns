using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class VolumeUpCommand(Television tv) : ICommand
{
    public void Execute()
    {
        tv.VolumeUp();
    }
}
