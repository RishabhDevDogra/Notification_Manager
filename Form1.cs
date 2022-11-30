using Notification_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Manager
{
    public partial class Form1 : Form
    {
        public static Form1 form;
        public static void UnHide()
        {
            form.Show();
        }
        public Form1()
        {
            InitializeComponent();
            form = this;
            DataTable dt = new DataTable();
            DataColumn column = new DataColumn("Subscriptions", typeof(string));
            dt.Columns.AddRange(new DataColumn[1] { column });
            foreach (KeyValuePair<string, SendViaEmail> kvp in Form2.emailDict) // prof. i used dictionary here  
            {
                dt.Rows.Add(kvp.Key);
            }
            foreach (KeyValuePair<string, SendViaMobile> kvp in Form2.SMSDict)
            {
                dt.Rows.Add(kvp.Key);
            }
            Form1.form.dataGridView.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.Location = this.Location;
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            f3.Location = this.Location;
            this.Hide();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
