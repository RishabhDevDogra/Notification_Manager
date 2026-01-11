namespace NotificationManagerApp;

/// <summary>
/// Main notification manager class that handles subscriptions and publishing
/// </summary>
public class NotificationManager
{
    private readonly Publisher _publisher = new();
    private readonly Dictionary<string, SendViaEmail> _emailSubscribers = new();
    private readonly Dictionary<string, SendViaMobile> _smsSubscribers = new();

    /// <summary>
    /// Subscribe an email address to notifications
    /// </summary>
    public void SubscribeEmail(string email)
    {
        if (_emailSubscribers.ContainsKey(email))
        {
            Console.WriteLine($"⚠️  Email {email} is already subscribed.");
            return;
        }

        var emailSender = new SendViaEmail(email);
        emailSender.Subscribe(_publisher);
        _emailSubscribers[email] = emailSender;
        Console.WriteLine($"✅ Email {email} subscribed successfully.");
    }

    /// <summary>
    /// Subscribe a phone number to notifications
    /// </summary>
    public void SubscribeMobile(string phoneNumber)
    {
        if (_smsSubscribers.ContainsKey(phoneNumber))
        {
            Console.WriteLine($"⚠️  Phone number {phoneNumber} is already subscribed.");
            return;
        }

        var smsSender = new SendViaMobile(phoneNumber);
        smsSender.Subscribe(_publisher);
        _smsSubscribers[phoneNumber] = smsSender;
        Console.WriteLine($"✅ Phone number {phoneNumber} subscribed successfully.");
    }

    /// <summary>
    /// Unsubscribe an email address
    /// </summary>
    public void UnsubscribeEmail(string email)
    {
        if (_emailSubscribers.ContainsKey(email))
        {
            _emailSubscribers[email].UnSubscribe(_publisher);
            _emailSubscribers.Remove(email);
            Console.WriteLine($"✅ Email {email} unsubscribed successfully.");
        }
        else
        {
            Console.WriteLine($"⚠️  Email {email} not found in subscriptions.");
        }
    }

    /// <summary>
    /// Unsubscribe a phone number
    /// </summary>
    public void UnsubscribeMobile(string phoneNumber)
    {
        if (_smsSubscribers.ContainsKey(phoneNumber))
        {
            _smsSubscribers[phoneNumber].UnSubscribe(_publisher);
            _smsSubscribers.Remove(phoneNumber);
            Console.WriteLine($"✅ Phone number {phoneNumber} unsubscribed successfully.");
        }
        else
        {
            Console.WriteLine($"⚠️  Phone number {phoneNumber} not found in subscriptions.");
        }
    }

    /// <summary>
    /// Publish a message to all subscribers
    /// </summary>
    public void PublishMessage(string message)
    {
        Console.WriteLine($"\n📢 Publishing message to {_emailSubscribers.Count + _smsSubscribers.Count} subscribers...");
        _publisher.PublishMessage(message);
        Console.WriteLine();
    }

    /// <summary>
    /// Display all current subscriptions
    /// </summary>
    public void DisplaySubscriptions()
    {
        Console.WriteLine("\n📋 Current Subscriptions:");
        Console.WriteLine("========================");

        if (_emailSubscribers.Count == 0 && _smsSubscribers.Count == 0)
        {
            Console.WriteLine("No subscriptions found.");
            return;
        }

        if (_emailSubscribers.Count > 0)
        {
            Console.WriteLine("\n📧 Email Subscriptions:");
            foreach (var email in _emailSubscribers.Keys)
            {
                Console.WriteLine($"  - {email}");
            }
        }

        if (_smsSubscribers.Count > 0)
        {
            Console.WriteLine("\n📱 SMS Subscriptions:");
            foreach (var phone in _smsSubscribers.Keys)
            {
                Console.WriteLine($"  - {phone}");
            }
        }
        Console.WriteLine();
    }
}
