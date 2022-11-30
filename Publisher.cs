namespace Notification_Manager
{
    public class Publisher
    {

        //Declaration of delegate class
        public delegate void PublishMessageDel(string msg);

        // Delegate object 
        public PublishMessageDel publishmsg = null;

        //Invoking the Delegate
        public void PublishMessage(string message)
        {
            
            publishmsg.Invoke(message);
        }
    }
}
