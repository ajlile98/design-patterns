using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class ChannelUpCommand(Television tv) : ICommand
{
    public void Execute()
    {
        tv.ChannelUp();
    }
}
