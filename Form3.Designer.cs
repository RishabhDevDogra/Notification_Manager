namespace Notification_Manager
{
    partial class Form3
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
            this.Pub_Pub_btn = new System.Windows.Forms.Button();
            this.ex_btn = new System.Windows.Forms.Button();
            this.nc_tb = new System.Windows.Forms.TextBox();
            this.nc_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pub_Pub_btn
            // 
            this.Pub_Pub_btn.Location = new System.Drawing.Point(73, 87);
            this.Pub_Pub_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pub_Pub_btn.Name = "Pub_Pub_btn";
            this.Pub_Pub_btn.Size = new System.Drawing.Size(100, 28);
            this.Pub_Pub_btn.TabIndex = 0;
            this.Pub_Pub_btn.Text = "Publish";
            this.Pub_Pub_btn.UseVisualStyleBackColor = true;
            this.Pub_Pub_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ex_btn
            // 
            this.ex_btn.Location = new System.Drawing.Point(341, 87);
            this.ex_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ex_btn.Name = "ex_btn";
            this.ex_btn.Size = new System.Drawing.Size(100, 28);
            this.ex_btn.TabIndex = 1;
            this.ex_btn.Text = "Exit";
            this.ex_btn.UseVisualStyleBackColor = true;
            this.ex_btn.Click += new System.EventHandler(this.ex_btn_Click);
            // 
            // nc_tb
            // 
            this.nc_tb.Location = new System.Drawing.Point(211, 38);
            this.nc_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nc_tb.Name = "nc_tb";
            this.nc_tb.Size = new System.Drawing.Size(229, 22);
            this.nc_tb.TabIndex = 2;
            this.nc_tb.TextChanged += new System.EventHandler(this.nc_tb_TextChanged);
            // 
            // nc_lbl
            // 
            this.nc_lbl.AutoSize = true;
            this.nc_lbl.Location = new System.Drawing.Point(69, 42);
            this.nc_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nc_lbl.Name = "nc_lbl";
            this.nc_lbl.Size = new System.Drawing.Size(121, 16);
            this.nc_lbl.TabIndex = 3;
            this.nc_lbl.Text = "Notification Content";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 313);
            this.Controls.Add(this.nc_lbl);
            this.Controls.Add(this.nc_tb);
            this.Controls.Add(this.ex_btn);
            this.Controls.Add(this.Pub_Pub_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pub_Pub_btn;
        private System.Windows.Forms.Button ex_btn;
        private System.Windows.Forms.TextBox nc_tb;
        private System.Windows.Forms.Label nc_lbl;
    }
}