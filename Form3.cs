using Notification_Manager;
using System;
using System.Windows.Forms;

namespace Notification_Manager

{
    public partial class Form3 : Form
    {
        public static Form3 form;
        public Form3()
        {
            InitializeComponent();
            form = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                Form2.publisher.PublishMessage(nc_tb.Text);
           
        }

        private void ex_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.UnHide();
            Form1.form.Location = this.Location;
        }


        private void nc_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
