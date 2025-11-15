using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class VolumeDownCommand(Television tv) : ICommand
{
    public void Execute()
    {
        tv.VolumeDown();
    }
}
