using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Notifications;

public class WhatsAppNotification(string recipient, string title, string message, bool useTemplate = true) : INotification
{
    public string Recipient { get; } = recipient;
    public string Title { get; } = title;
    public string Message { get; } = message;
    public bool UseTemplate { get; } = useTemplate;
    
    public void Send()
    {
        Console.WriteLine($"Enviando WhatsApp para {Recipient}");
        Console.WriteLine($"Mensagem: {Message}");
        Console.WriteLine($"Template: {UseTemplate}");
    }
}