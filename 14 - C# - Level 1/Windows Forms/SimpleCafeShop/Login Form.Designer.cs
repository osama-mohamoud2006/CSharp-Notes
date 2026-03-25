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
            this.txtAccNum = new System.Windows.Forms.RichTextBox();
            this.txtAccPass = new System.Windows.Forms.RichTextBox();
            this.LabAccNum = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
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
            // txtAccNum
            // 
            this.txtAccNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAccNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.Location = new System.Drawing.Point(209, 174);
            this.txtAccNum.MaxLength = 6;
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(134, 30);
            this.txtAccNum.TabIndex = 0;
            this.txtAccNum.Text = "";
            this.txtAccNum.WordWrap = false;
            this.txtAccNum.MouseEnter += new System.EventHandler(this.MouseEnteredAccNum);
            this.txtAccNum.MouseLeave += new System.EventHandler(this.MouseLeftAccNum);
            // 
            // txtAccPass
            // 
            this.txtAccPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAccPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccPass.Location = new System.Drawing.Point(209, 265);
            this.txtAccPass.MaxLength = 10;
            this.txtAccPass.Name = "txtAccPass";
            this.txtAccPass.Size = new System.Drawing.Size(134, 30);
            this.txtAccPass.TabIndex = 1;
            this.txtAccPass.Text = "";
            this.txtAccPass.WordWrap = false;
            this.txtAccPass.MouseEnter += new System.EventHandler(this.MouseEnteredPass);
            this.txtAccPass.MouseLeave += new System.EventHandler(this.MouseLeftPass);
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
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("SF Pro Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(202, 387);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 53);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 567);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.LabAccNum);
            this.Controls.Add(this.txtAccPass);
            this.Controls.Add(this.txtAccNum);
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
        private System.Windows.Forms.RichTextBox txtAccNum;
        private System.Windows.Forms.RichTextBox txtAccPass;
        private System.Windows.Forms.Label LabAccNum;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Button btnLogin;
    }
}

