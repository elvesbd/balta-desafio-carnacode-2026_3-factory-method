using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Notifications;

namespace DesignPatternChallenge.Creators;

public class PushNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification(string recipient, string title, string message)
    {
        return new PushNotification(recipient, title, message);
    }
}