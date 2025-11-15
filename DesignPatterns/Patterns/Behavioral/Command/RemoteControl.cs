using System;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class RemoteControl(Television tv)
{
    private readonly ICommand volumeUp = new VolumeUpCommand(tv);
    private readonly ICommand volumeDown = new VolumeUpCommand(tv);
    private readonly ICommand channelUp = new ChannelUpCommand(tv);
    private readonly ICommand channelDown = new ChannelDownCommand(tv);
    private readonly ICommand togglePower = new TogglePowerCommand(tv);


    public void VolumeUp()
    {
        volumeUp.Execute();
    }
    public void VolumeDown()
    {
        volumeDown.Execute();
    }
    public void ChannelUp()
    {
        channelUp.Execute();
    }
    public void ChannelDown()
    {
        channelDown.Execute();
    }
    public void TogglePower()
    {
        togglePower.Execute();
    }
}
