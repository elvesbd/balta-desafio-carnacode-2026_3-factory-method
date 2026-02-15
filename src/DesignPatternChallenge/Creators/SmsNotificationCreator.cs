using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Notifications;

namespace DesignPatternChallenge.Creators;

public class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification(string recipient, string title, string message)
    {
        return new SmsNotification(recipient, title, message);
    }
}