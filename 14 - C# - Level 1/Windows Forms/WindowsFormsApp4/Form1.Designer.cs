namespace WindowsFormsApp4
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fuiTextBox1 = new FastUI.FastUILibrary.Components.FuiTextBox();
            this.fuiTime1 = new FastUI.FastUILibrary.Components.FuiTime();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(310, 217);
            this.textBoxUsername.MaxLength = 5;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '*';
            this.textBoxUsername.Size = new System.Drawing.Size(259, 22);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "hi";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(310, 245);
            this.textBoxPassword.MaxLength = 5;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(259, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "hi";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(164, 334);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(202, 71);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "button1";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(372, 334);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(202, 71);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "button1";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(371, 270);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(109, 17);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassword_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(794, 35);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Hello World";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 217);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "hi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fuiTime1);
            this.groupBox1.Controls.Add(this.fuiTextBox1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(82, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(240, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "اهلا بالعالم";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(82, 338);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 24);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Hello World";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(563, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(193, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(254, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(296, 22);
            this.textBox5.TabIndex = 6;
            // 
            // fuiTextBox1
            // 
            this.fuiTextBox1.AllowSpace = false;
            this.fuiTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.fuiTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiTextBox1.BorderWidth = 1.2F;
            this.fuiTextBox1.CornerRadius = 6F;
            this.fuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fuiTextBox1.FastText = "hi";
            this.fuiTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiTextBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fuiTextBox1.Font = new System.Drawing.Font("SF Mono", 10.5F);
            this.fuiTextBox1.FontSize = 10.5F;
            this.fuiTextBox1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiTextBox1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fuiTextBox1.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            this.fuiTextBox1.Location = new System.Drawing.Point(583, 137);
            this.fuiTextBox1.MoveTextHorizontal = 6;
            this.fuiTextBox1.MoveTextVertical = 0;
            this.fuiTextBox1.Name = "fuiTextBox1";
            this.fuiTextBox1.Placeholder = "123";
            this.fuiTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTextBox1.Size = new System.Drawing.Size(149, 59);
            this.fuiTextBox1.TabIndex = 7;
            this.fuiTextBox1.Text = "fuiTextBox1";
            this.fuiTextBox1.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.fuiTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiTextBox1.Theme = "Windows11";
            // 
            // fuiTime1
            // 
            this.fuiTime1.BackColor = System.Drawing.Color.Transparent;
            this.fuiTime1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fuiTime1.BorderWidth = 1.2F;
            this.fuiTime1.CornerRadius = 6F;
            this.fuiTime1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fuiTime1.FastText = "";
            this.fuiTime1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fuiTime1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTime1.FocusFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fuiTime1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.fuiTime1.FontSize = 10.5F;
            this.fuiTime1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fuiTime1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.fuiTime1.Location = new System.Drawing.Point(101, 136);
            this.fuiTime1.MoveTextHorizontal = 6;
            this.fuiTime1.MoveTextVertical = 0;
            this.fuiTime1.Name = "fuiTime1";
            this.fuiTime1.Placeholder = "HH:mm";
            this.fuiTime1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTime1.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.fuiTime1.Required = false;
            this.fuiTime1.Size = new System.Drawing.Size(164, 59);
            this.fuiTime1.TabIndex = 8;
            this.fuiTime1.Text = "fuiTime1";
            this.fuiTime1.TextAlignment = FastUI.FastUILibrary.Core.FastTextAlign.Left;
            this.fuiTime1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fuiTime1.Theme = "Windows11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private FastUI.FastUILibrary.Components.FuiTextBox fuiTextBox1;
        private FastUI.FastUILibrary.Components.FuiTime fuiTime1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
    }
}

