using NotificationManagerApp;

Console.WriteLine("╔════════════════════════════════════════╗");
Console.WriteLine("║   Notification Manager - Cross Platform║");
Console.WriteLine("║            Running on .NET 6+          ║");
Console.WriteLine("╚════════════════════════════════════════╝\n");

var manager = new NotificationManager();
bool running = true;

while (running)
{
    Console.WriteLine("\n📌 Main Menu:");
    Console.WriteLine("─────────────────────");
    Console.WriteLine("1. Subscribe to Email Notifications");
    Console.WriteLine("2. Subscribe to SMS Notifications");
    Console.WriteLine("3. Unsubscribe from Email");
    Console.WriteLine("4. Unsubscribe from SMS");
    Console.WriteLine("5. View All Subscriptions");
    Console.WriteLine("6. Publish Message to All Subscribers");
    Console.WriteLine("7. Exit");
    Console.WriteLine("─────────────────────");
    Console.Write("Enter your choice (1-7): ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("\nEnter email address: ");
            string? email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email))
            {
                manager.SubscribeEmail(email);
            }
            break;

        case "2":
            Console.Write("\nEnter phone number: ");
            string? phone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phone))
            {
                manager.SubscribeMobile(phone);
            }
            break;

        case "3":
            Console.Write("\nEnter email address to unsubscribe: ");
            string? emailUnsub = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(emailUnsub))
            {
                manager.UnsubscribeEmail(emailUnsub);
            }
            break;

        case "4":
            Console.Write("\nEnter phone number to unsubscribe: ");
            string? phoneUnsub = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phoneUnsub))
            {
                manager.UnsubscribeMobile(phoneUnsub);
            }
            break;

        case "5":
            manager.DisplaySubscriptions();
            break;

        case "6":
            Console.Write("\nEnter message to publish: ");
            string? message = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(message))
            {
                manager.PublishMessage(message);
            }
            break;

        case "7":
            running = false;
            Console.WriteLine("\n👋 Thank you for using Notification Manager. Goodbye!");
            break;

        default:
            Console.WriteLine("\n⚠️  Invalid choice. Please try again.");
            break;
    }
}

