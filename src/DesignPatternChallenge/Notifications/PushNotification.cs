using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Notifications;

public class PushNotification(string recipient, string title, string message, int badge) : INotification
{
    public string Recipient { get; } = recipient;
    public string Title { get; }  = title;
    public string Message { get; } = message;
    public int Badge { get; set; } = badge;
    
    public void Send()
    {
        Console.WriteLine($"Enviando Push para dispositivo {Recipient}");
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Mensagem: {Message}");
    }
}