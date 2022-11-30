namespace Notification_Manager
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message_pn = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message_pn
            // 
            this.Message_pn.AllowDrop = true;
            this.Message_pn.AutoSize = true;
            this.Message_pn.Location = new System.Drawing.Point(39, 33);
            this.Message_pn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message_pn.MaximumSize = new System.Drawing.Size(333, 0);
            this.Message_pn.Name = "Message_pn";
            this.Message_pn.Size = new System.Drawing.Size(0, 16);
            this.Message_pn.TabIndex = 0;
            this.Message_pn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Message_pn.UseMnemonic = false;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(151, 95);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(100, 28);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 146);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.Message_pn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notification";
            this.Text = "Notification_Box";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirm_btn;
        public System.Windows.Forms.Label Message_pn;
    }
}