using DesignPatternChallenge.Creators;

namespace DesignPatternChallenge.Services;

public class NotificationManager(NotificationCreator creator)
{
    private readonly NotificationCreator _creator = creator;

    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        _creator.Notify(recipient, "Confirmação de Pedido", $"Seu pedido {orderNumber} foi confirmado!");
    }

    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        _creator.Notify(recipient, "Pedido Enviado", $"Seu pedido foi enviado! Rastreamento: {trackingCode}");
    }

    public void SendPaymentReminder(string recipient, decimal amount)
    {
        _creator.Notify(recipient, "Lembrete de Pagamento", $"Você tem um pagamento pendente de R$ {amount:N2}");
    }
}