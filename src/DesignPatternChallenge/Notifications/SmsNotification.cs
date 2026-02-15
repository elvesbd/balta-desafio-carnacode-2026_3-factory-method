using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Notifications;

public class SmsNotification(string recipient, string title, string message) : INotification
{
    public string Recipient { get; } = recipient;
    public string Title { get; } = title;
    public string Message { get; } = message;
    
    public void Send()
    {
        Console.WriteLine($"Enviando SMS para {Recipient}");
        Console.WriteLine($"Mensagem: {Message}");
    }
}