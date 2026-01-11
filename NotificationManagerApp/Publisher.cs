namespace NotificationManagerApp;

/// <summary>
/// Publisher class that manages notification publishing using delegates and events
/// </summary>
public class Publisher
{
    // Declaration of delegate class
    public delegate void PublishMessageDel(string msg);

    // Delegate object 
    public PublishMessageDel? PublishMsg { get; set; }

    // Invoking the Delegate
    public void PublishMessage(string message)
    {
        PublishMsg?.Invoke(message);
    }
}
