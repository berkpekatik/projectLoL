namespace ProjectLoL
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
            this.button1 = new System.Windows.Forms.Button();
            this.sumName = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(166, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumName
            // 
            this.sumName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sumName.Location = new System.Drawing.Point(145, 26);
            this.sumName.Name = "sumName";
            this.sumName.Size = new System.Drawing.Size(121, 27);
            this.sumName.TabIndex = 1;
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Tahoma", 12F);
            this.server.FormattingEnabled = true;
            this.server.Items.AddRange(new object[] {
            "TR",
            "BR",
            "EUNE",
            "EUW",
            "LAN",
            "LAS",
            "NA",
            "OCE",
            "RU",
            "JP"});
            this.server.Location = new System.Drawing.Point(145, 59);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(121, 27);
            this.server.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sumonner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server);
            this.Controls.Add(this.sumName);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sumName;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}