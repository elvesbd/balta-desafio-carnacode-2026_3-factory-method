using DesignPatternChallenge.Creators;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Notificações - Factory Method ===\n");

var emailManager = new NotificationManager(new EmailNotificationCreator());
emailManager.SendOrderConfirmation("cliente@email.com", "123456");
Console.WriteLine();

var smsManager = new NotificationManager(new SmsNotificationCreator());
smsManager.SendOrderConfirmation("+5511999999999", "12346");
Console.WriteLine();

var pushManager = new NotificationManager(new PushNotificationCreator());
pushManager.SendShippingUpdate("device-token-abc123", "BR123456789");
Console.WriteLine();

var whatsAppManager = new NotificationManager(new WhatsAppNotificationCreator());
whatsAppManager.SendPaymentReminder("+5511888888888", 150.00m);