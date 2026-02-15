using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Notifications;

namespace DesignPatternChallenge.Creators;

public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification(string recipient, string title, string message)
    {
        return new EmailNotification(recipient, title, message);
    }
}