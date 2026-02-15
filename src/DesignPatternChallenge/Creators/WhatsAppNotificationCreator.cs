using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Notifications;

namespace DesignPatternChallenge.Creators;

public class WhatsAppNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification(string recipient, string title, string message)
    {
        return new WhatsAppNotification(recipient, title, message);
    }
}