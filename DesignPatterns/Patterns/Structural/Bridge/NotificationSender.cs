namespace DesignPatterns.Patterns.Structural.Bridge;

public class NotificationSender(INotificationSenderImp imp)
{
  public void SendNotification()
  {
    imp.SendNotificationImp();
  }

}