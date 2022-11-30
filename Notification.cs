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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }
    }
}
