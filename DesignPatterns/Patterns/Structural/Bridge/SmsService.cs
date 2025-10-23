using System;

namespace DesignPatterns.Patterns.Structural.Bridge;

public class SmsService : INotificationSenderImp
{
  public void SendNotificationImp()
  {
    Console.WriteLine("Sending SMS from SmsService...");
  }
}
