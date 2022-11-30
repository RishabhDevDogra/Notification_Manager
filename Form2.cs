
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Notification_Manager
{

    public partial class Form2 : Form
    {
        public static Form2 form;
        public static Dictionary<string, SendViaEmail> emailDict = new Dictionary<string, SendViaEmail>();
        public static Dictionary<string, SendViaMobile> SMSDict = new Dictionary<string, SendViaMobile>();
        public static Publisher publisher = new Publisher();
        public Form2()
        {
            InitializeComponent();
            form = this;
        }

        private void Email_cb_CheckedChanged(object sender, EventArgs e) // use of checkbox
        {
            warn_lbl.Text = "";
            warn2_lbl.Text = "";
            if (this.Email_cb.Checked)
            {
                SMS_tb.Enabled = false;
                SMS_tb.Text = "";
                SMS_cb.Checked = false;
                Email_tb.Enabled = true;
            }
        }

        private void Sub_Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sub_Unsub_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.Email_cb.Checked && Email_tb.Text.Length > 0)
                {
                    string key = Email_tb.Text;
                    emailDict[key].UnSubscribe(publisher);
                    emailDict.Remove(key);
                    Notification nb2 = new Notification();
                    nb2.Show();
                    nb2.Message_pn.Text = "Email: " + key + " has unsubscribed our service successfully.";
                    nb2.Location = this.Location;
                }
                if (this.SMS_cb.Checked && SMS_tb.Text.Length > 0)
                {
                    string key = SMS_tb.Text;
                    SMSDict[key].UnSubscribe(publisher);
                    SMSDict.Remove(key);
                    Notification nb2 = new Notification();
                    nb2.Show();
                    nb2.Message_pn.Text = "Phone Number: " + key + " has unsubscribed our service successfully.";
                    nb2.Location = this.Location;
                }
            }
            catch (Exception err)
            {
                Notification nb1 = new Notification();
                nb1.Show();
                nb1.Message_pn.Text = "Err:" + err.Message;
                nb1.Location = this.Location;
            }
        }

        private void Sub_Sub_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Email_cb.Checked && Email_tb.Text.Length > 0)
                {
                    Regex rx = new Regex(@"^([\w\.\-]+)@([\w\.\-]+)\.([\w\.\-]+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase); //Prof i took help from the documenetation and stackoverflow for Regex statement https://stackoverflow.com/questions/5342375/regex-email-validation
                    string s = Email_tb.Text;
                    if (!rx.IsMatch(s))
                    {
                        warn_lbl.Text = "Please enter correct email address.";
                        warn_lbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        SendViaEmail subs = new SendViaEmail(s);
                        subs.Subscribe(publisher);
                        emailDict.Add(s, subs);
                        Notification nb2 = new Notification();
                        nb2.Show();
                        nb2.Message_pn.Text = "Eamil: " + s + " has subscribed our service successfully.";
                        nb2.Location = this.Location;
                    }
                }
                if (this.SMS_cb.Checked && SMS_tb.Text.Length > 0)
                {
                    Regex rx = new Regex(@"^([0-9]{10})$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    string s = SMS_tb.Text;
                    if (!rx.IsMatch(s))
                    {
                        warn2_lbl.Text = "Please enter correct phone number.";
                        warn2_lbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        SendViaMobile subs = new SendViaMobile(s);
                        subs.Subscribe(publisher);
                        SMSDict.Add(s, subs);
                        Notification nb2 = new Notification();
                        nb2.Show();
                        nb2.Message_pn.Text = "Phone Number: " + s + " has subscribed our service successfully.";
                        nb2.Location = this.Location;
                    }

                }
            }
            catch (Exception err)
            {
                Notification nb1 = new  Notification ();
                nb1.Show();
                nb1.Message_pn.Text = "Err:" + err.Message;
                nb1.Location = this.Location;
            }

        }

        private void SMS_cb_CheckedChanged(object sender, EventArgs e)
        {
            warn_lbl.Text = "";
            warn2_lbl.Text = "";
            if (SMS_cb.Checked)
            {
                Email_tb.Text = "";
                Email_tb.Enabled = false;
                Email_cb.Checked = false;
                SMS_tb.Enabled = true;
            }
        }


        private void Email_tb_TextChanged(object sender, EventArgs e)
        {
            warn_lbl.Text = "";
            warn2_lbl.Text = "";
        }

        private void SMS_tb_TextChanged(object sender, EventArgs e)
        {
            warn_lbl.Text = "";
            warn2_lbl.Text = "";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.UnHide();
            Form1.form.Location = this.Location;
            if ((emailDict.Count + SMSDict.Count) > 0)
            {
                Form1.form.Pub_btn.Enabled = true;
            }
            DataTable dt = new DataTable();
            DataColumn column = new DataColumn("Subscriptions", typeof(string));
            dt.Columns.AddRange(new DataColumn[1] { column });
            foreach (KeyValuePair<string, SendViaEmail> kvp in emailDict)
            {
                dt.Rows.Add(kvp.Key);
            }
            foreach (KeyValuePair<string, SendViaMobile> kvp in SMSDict)
            {
                dt.Rows.Add(kvp.Key);
            }
            Form1.form.dataGridView.DataSource = dt;
           
        }
    }
}
