namespace SimpleCafeShop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labLogin = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.LabAccNum = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labLogin
            // 
            this.labLogin.BackColor = System.Drawing.Color.Transparent;
            this.labLogin.Font = new System.Drawing.Font("SF Pro Display", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.ForeColor = System.Drawing.Color.Transparent;
            this.labLogin.Location = new System.Drawing.Point(187, 39);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(178, 67);
            this.labLogin.TabIndex = 1;
            this.labLogin.Text = "Login";
            this.labLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(209, 174);
            this.richTextBox1.MaxLength = 6;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(134, 30);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(209, 265);
            this.richTextBox2.MaxLength = 10;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(134, 30);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // LabAccNum
            // 
            this.LabAccNum.AutoSize = true;
            this.LabAccNum.BackColor = System.Drawing.Color.Transparent;
            this.LabAccNum.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAccNum.ForeColor = System.Drawing.Color.White;
            this.LabAccNum.Location = new System.Drawing.Point(49, 180);
            this.LabAccNum.Name = "LabAccNum";
            this.LabAccNum.Size = new System.Drawing.Size(109, 18);
            this.LabAccNum.TabIndex = 4;
            this.LabAccNum.Text = "Enter Acc Num";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.BackColor = System.Drawing.Color.Transparent;
            this.labPass.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPass.ForeColor = System.Drawing.Color.White;
            this.labPass.Location = new System.Drawing.Point(49, 271);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(108, 18);
            this.labPass.TabIndex = 1;
            this.labPass.Text = "Enter Acc Pass";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 567);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.LabAccNum);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labLogin);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label LabAccNum;
        private System.Windows.Forms.Label labPass;
    }
}

