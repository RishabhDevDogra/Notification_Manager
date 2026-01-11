namespace NotificationManagerApp;

/// <summary>
/// Handles sending notifications via email
/// </summary>
public class SendViaEmail
{
    public string EmailAddr { get; set; }

    public SendViaEmail() 
    {
        EmailAddr = string.Empty;
    }

    public SendViaEmail(string emailAddr)
    {
        EmailAddr = emailAddr;
    }

    public void SendEmail(string msg)
    {
        Console.WriteLine($"📧 Email sent to {EmailAddr}: \"{msg}\"");
    }

    public void Subscribe(Publisher pub)
    {
        pub.PublishMsg += SendEmail;
    }

    public void UnSubscribe(Publisher pub)
    {
        pub.PublishMsg -= SendEmail;
    }
}
