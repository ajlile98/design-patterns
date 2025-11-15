using System;
using System.Threading.Channels;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class Television(int Channel = 3, int Volume = 5, bool On = false)
{
    public void ChannelUp()
    {
        if (!On) return;
        if (Channel > 100)
            return;
        Channel += 1;
    }
    public void ChannelDown()
    {
        if (!On) return;
        if (Channel <= 1)
            return;
        Channel -= 1;
    }
    public void VolumeUp()
    {
        if (!On) return;
        if (Volume > 100)
            return;
        Volume += 1;
    }
    public void VolumeDown()
    {
        if (!On) return;
        if (Volume <= 1)
            return;
        Volume -= 1;
    }
    public void TogglePower()
    {
        On = !On;
    }

    public override string ToString()
    {
        string status = On ? "On" : "Off";
        return $"Television [Power: {status}, Channel: {Channel}, Volume: {Volume}]";
    }
}
