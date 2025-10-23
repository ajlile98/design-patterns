using System;

namespace DesignPatterns.Patterns.Structural.Bridge;

public class EmailService : INotificationSenderImp
{
  public void SendNotificationImp()
  {
    Console.WriteLine("Sending Email from EmailService...");
  }
}
