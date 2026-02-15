using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Creators;

public abstract class NotificationCreator
{
    protected abstract INotification CreateNotification(string recipient, string title, string message);

    public void Notify(string recipient, string title, string message)
    {
        var notification = CreateNotification(recipient, title, message);
        notification.Send();
    }
}