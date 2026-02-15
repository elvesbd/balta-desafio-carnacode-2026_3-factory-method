using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Notifications;

public class EmailNotification(string recipient, string title, string message, bool isHtml = true) : INotification
{
    public string Recipient { get; } = recipient;
    public string Title { get; } = title;
    public string Message { get; } = message;
    public bool IsHtml { get; } = isHtml;

    public void Send()
    {
        Console.WriteLine($"Enviando Email para {Recipient}");
        Console.WriteLine($"Assunto: {Title}");
        Console.WriteLine($"Mensagem: {Message}");
    }
}