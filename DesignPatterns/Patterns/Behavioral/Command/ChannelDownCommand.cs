using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class ChannelDownCommand(Television tv) : ICommand
{
    public void Execute()
    {
        tv.ChannelDown();
    }
}
