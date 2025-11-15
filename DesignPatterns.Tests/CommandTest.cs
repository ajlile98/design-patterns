using System;
using DesignPatterns.Patterns.Behavioral.Command;

namespace DesignPatterns.Tests;

public class CommandTest
{
    [Fact]
    public void TestCommand()
    {
        var tv = new Television();
        var remote = new RemoteControl(tv);
        Console.WriteLine(tv);
        remote.TogglePower();
        remote.ChannelUp();
        remote.VolumeUp();
        Console.WriteLine(tv);
    }
}
