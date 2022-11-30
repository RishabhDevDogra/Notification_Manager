using Notification_Manager; 
using System;

namespace Notification_Manager

{
    public class SendViaEmail
    {
        
        public String EmailAddr { get; set; }

        public SendViaEmail() { }


        public SendViaEmail(String emailAddr)
        {
            EmailAddr = emailAddr;
        }

        public void sendEmail(string msg)


        {

            Notification notification = new Notification();
            notification.Show();
            notification.Message_pn.Text = "The message" + "\"" + msg + "\" has already sent to " + EmailAddr;
            notification.Location = Form3.form.Location;

        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail; // Prof. i used operator here to append the message.
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
