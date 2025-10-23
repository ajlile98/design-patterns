using System;
using DesignPatterns.Patterns.Structural.Bridge;

namespace DesignPatterns.Tests;

public class BridgeTest
{
  [Fact]
  public void TestBridge()
  {
    List<NotificationSender> senders = new();
    senders.Add(new NotificationSender(new EmailService()));
    senders.Add(new NotificationSender(new SmsService()));

    foreach(var sender in senders)
    {
      sender.SendNotification();
    }
    
  }
}
