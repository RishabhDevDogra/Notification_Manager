namespace Notification_Manager
{
    partial class Form2
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
            this.Email_cb = new System.Windows.Forms.CheckBox();
            this.SMS_cb = new System.Windows.Forms.CheckBox();
            this.Sub_Sub_btn = new System.Windows.Forms.Button();
            this.Sub_Unsub_btn = new System.Windows.Forms.Button();
            this.Sub_Cancel_btn = new System.Windows.Forms.Button();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.SMS_tb = new System.Windows.Forms.TextBox();
            this.warn_lbl = new System.Windows.Forms.Label();
            this.warn2_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email_cb
            // 
            this.Email_cb.AutoSize = true;
            this.Email_cb.Location = new System.Drawing.Point(61, 60);
            this.Email_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_cb.Name = "Email_cb";
            this.Email_cb.Size = new System.Drawing.Size(180, 20);
            this.Email_cb.TabIndex = 0;
            this.Email_cb.Text = "Notification Sent by Email";
            this.Email_cb.UseVisualStyleBackColor = true;
            this.Email_cb.CheckedChanged += new System.EventHandler(this.Email_cb_CheckedChanged);
            // 
            // SMS_cb
            // 
            this.SMS_cb.AutoSize = true;
            this.SMS_cb.Location = new System.Drawing.Point(61, 126);
            this.SMS_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SMS_cb.Name = "SMS_cb";
            this.SMS_cb.Size = new System.Drawing.Size(175, 20);
            this.SMS_cb.TabIndex = 1;
            this.SMS_cb.Text = "Notification Sent by SMS";
            this.SMS_cb.UseVisualStyleBackColor = true;
            this.SMS_cb.CheckedChanged += new System.EventHandler(this.SMS_cb_CheckedChanged);
            // 
            // Sub_Sub_btn
            // 
            this.Sub_Sub_btn.Location = new System.Drawing.Point(61, 193);
            this.Sub_Sub_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sub_Sub_btn.Name = "Sub_Sub_btn";
            this.Sub_Sub_btn.Size = new System.Drawing.Size(100, 28);
            this.Sub_Sub_btn.TabIndex = 2;
            this.Sub_Sub_btn.Text = "Subscribe";
            this.Sub_Sub_btn.UseVisualStyleBackColor = true;
            this.Sub_Sub_btn.Click += new System.EventHandler(this.Sub_Sub_btn_Click);
            // 
            // Sub_Unsub_btn
            // 
            this.Sub_Unsub_btn.Location = new System.Drawing.Point(307, 193);
            this.Sub_Unsub_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sub_Unsub_btn.Name = "Sub_Unsub_btn";
            this.Sub_Unsub_btn.Size = new System.Drawing.Size(100, 28);
            this.Sub_Unsub_btn.TabIndex = 3;
            this.Sub_Unsub_btn.Text = "Unsubscribe";
            this.Sub_Unsub_btn.UseVisualStyleBackColor = true;
            this.Sub_Unsub_btn.Click += new System.EventHandler(this.Sub_Unsub_btn_Click);
            // 
            // Sub_Cancel_btn
            // 
            this.Sub_Cancel_btn.Location = new System.Drawing.Point(523, 193);
            this.Sub_Cancel_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sub_Cancel_btn.Name = "Sub_Cancel_btn";
            this.Sub_Cancel_btn.Size = new System.Drawing.Size(100, 28);
            this.Sub_Cancel_btn.TabIndex = 4;
            this.Sub_Cancel_btn.Text = "Return";
            this.Sub_Cancel_btn.UseVisualStyleBackColor = true;
            this.Sub_Cancel_btn.Click += new System.EventHandler(this.Sub_Cancel_btn_Click);
            // 
            // Email_tb
            // 
            this.Email_tb.Location = new System.Drawing.Point(307, 60);
            this.Email_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(315, 22);
            this.Email_tb.TabIndex = 5;
            this.Email_tb.TextChanged += new System.EventHandler(this.Email_tb_TextChanged);
            // 
            // SMS_tb
            // 
            this.SMS_tb.Location = new System.Drawing.Point(307, 126);
            this.SMS_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SMS_tb.Name = "SMS_tb";
            this.SMS_tb.Size = new System.Drawing.Size(315, 22);
            this.SMS_tb.TabIndex = 6;
            this.SMS_tb.TextChanged += new System.EventHandler(this.SMS_tb_TextChanged);
            // 
            // warn_lbl
            // 
            this.warn_lbl.AutoSize = true;
            this.warn_lbl.ForeColor = System.Drawing.Color.Red;
            this.warn_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warn_lbl.Location = new System.Drawing.Point(311, 95);
            this.warn_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warn_lbl.Name = "warn_lbl";
            this.warn_lbl.Size = new System.Drawing.Size(0, 16);
            this.warn_lbl.TabIndex = 7;
            // 
            // warn2_lbl
            // 
            this.warn2_lbl.AutoSize = true;
            this.warn2_lbl.ForeColor = System.Drawing.Color.Red;
            this.warn2_lbl.Location = new System.Drawing.Point(311, 165);
            this.warn2_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warn2_lbl.Name = "warn2_lbl";
            this.warn2_lbl.Size = new System.Drawing.Size(0, 16);
            this.warn2_lbl.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 423);
            this.Controls.Add(this.warn2_lbl);
            this.Controls.Add(this.warn_lbl);
            this.Controls.Add(this.SMS_tb);
            this.Controls.Add(this.Email_tb);
            this.Controls.Add(this.Sub_Cancel_btn);
            this.Controls.Add(this.Sub_Unsub_btn);
            this.Controls.Add(this.Sub_Sub_btn);
            this.Controls.Add(this.SMS_cb);
            this.Controls.Add(this.Email_cb);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sub_Sub_btn;
        private System.Windows.Forms.Button Sub_Unsub_btn;
        private System.Windows.Forms.Button Sub_Cancel_btn;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.TextBox SMS_tb;
        internal System.Windows.Forms.CheckBox Email_cb;
        internal System.Windows.Forms.CheckBox SMS_cb;
        private System.Windows.Forms.Label warn_lbl;
        private System.Windows.Forms.Label warn2_lbl;
    }
}