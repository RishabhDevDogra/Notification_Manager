namespace NotificationManagerApp;

/// <summary>
/// Handles sending notifications via SMS
/// </summary>
public class SendViaMobile
{
    public string PhoneNumber { get; set; }

    public SendViaMobile()
    {
        PhoneNumber = string.Empty;
    }

    public SendViaMobile(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void SendSMS(string msg)
    {
        Console.WriteLine($"📱 SMS sent to {PhoneNumber}: \"{msg}\"");
    }

    public void Subscribe(Publisher pub)
    {
        pub.PublishMsg += SendSMS;
    }

    public void UnSubscribe(Publisher pub)
    {
        pub.PublishMsg -= SendSMS;
    }
}
