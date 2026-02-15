namespace DesignPatternChallenge.Abstractions;

public interface INotification
{
    public string Recipient { get; }
    public string Title { get; }
    public string Message { get; }
    void Send();
}