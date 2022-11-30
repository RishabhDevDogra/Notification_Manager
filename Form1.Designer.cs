namespace Notification_Manager
{
    partial class Form1
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
            this.Sub_btn = new System.Windows.Forms.Button();
            this.Pub_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Sub_btn
            // 
            this.Sub_btn.Location = new System.Drawing.Point(16, 39);
            this.Sub_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Sub_btn.Name = "Sub_btn";
            this.Sub_btn.Size = new System.Drawing.Size(191, 28);
            this.Sub_btn.TabIndex = 0;
            this.Sub_btn.Text = "Manage Subscription";
            this.Sub_btn.UseVisualStyleBackColor = true;
            this.Sub_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pub_btn
            // 
            this.Pub_btn.Enabled = false;
            this.Pub_btn.Location = new System.Drawing.Point(215, 39);
            this.Pub_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Pub_btn.Name = "Pub_btn";
            this.Pub_btn.Size = new System.Drawing.Size(191, 28);
            this.Pub_btn.TabIndex = 1;
            this.Pub_btn.Text = "Publish Notification";
            this.Pub_btn.UseVisualStyleBackColor = true;
            this.Pub_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(413, 39);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(121, 28);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 102);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(519, 207);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 452);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Pub_btn);
            this.Controls.Add(this.Sub_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Sub_btn;
        public System.Windows.Forms.Button Pub_btn;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}

