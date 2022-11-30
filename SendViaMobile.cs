using Notification_Manager;
using System;

namespace Notification_Manager
{
    public class SendViaMobile //Same as SendViaEmail
    {

        
        public String MobileNumber { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            MobileNumber = phone;
        }

        private void sendMessage(string msg)
        {
            Notification notification = new Notification();
            notification.Show();
            notification.Message_pn.Text = "The message" + "\"" + msg + "\" has already sent to " + MobileNumber;
            notification.Location = Form3.form.Location;
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessage;
        }


    }
}
