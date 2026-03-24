namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.RichTextBox();
            this.Box2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.EnableBox = new System.Windows.Forms.Button();
            this.BoxOneToBRed = new System.Windows.Forms.Button();
            this.TextBoxOneBWhite = new System.Windows.Forms.Button();
            this.RandomColorOfForm = new System.Windows.Forms.Button();
            this.ChangeTitle = new System.Windows.Forms.Button();
            this.ChangeLabel1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HideTextBoxOne = new System.Windows.Forms.Button();
            this.EnableAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Pressing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Copy";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(146, 130);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(226, 84);
            this.Box1.TabIndex = 1;
            this.Box1.Text = "Box1";
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // Box2
            // 
            this.Box2.Enabled = false;
            this.Box2.Location = new System.Drawing.Point(759, 130);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(226, 84);
            this.Box2.TabIndex = 2;
            this.Box2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Enabled = false;
            this.DisableButton.Location = new System.Drawing.Point(744, 380);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(261, 60);
            this.DisableButton.TabIndex = 5;
            this.DisableButton.Text = "Disable Text Box 1";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // EnableBox
            // 
            this.EnableBox.Enabled = false;
            this.EnableBox.Location = new System.Drawing.Point(744, 451);
            this.EnableBox.Name = "EnableBox";
            this.EnableBox.Size = new System.Drawing.Size(261, 60);
            this.EnableBox.TabIndex = 6;
            this.EnableBox.Text = "Enable Text Box 1";
            this.EnableBox.UseVisualStyleBackColor = true;
            this.EnableBox.Click += new System.EventHandler(this.EnableBox_Click);
            // 
            // BoxOneToBRed
            // 
            this.BoxOneToBRed.Location = new System.Drawing.Point(111, 384);
            this.BoxOneToBRed.Name = "BoxOneToBRed";
            this.BoxOneToBRed.Size = new System.Drawing.Size(289, 49);
            this.BoxOneToBRed.TabIndex = 9;
            this.BoxOneToBRed.Text = "Text Box 1 To Red";
            this.BoxOneToBRed.UseVisualStyleBackColor = true;
            this.BoxOneToBRed.Click += new System.EventHandler(this.BoxOneToBRed_Click);
            // 
            // TextBoxOneBWhite
            // 
            this.TextBoxOneBWhite.Location = new System.Drawing.Point(111, 457);
            this.TextBoxOneBWhite.Name = "TextBoxOneBWhite";
            this.TextBoxOneBWhite.Size = new System.Drawing.Size(289, 49);
            this.TextBoxOneBWhite.TabIndex = 10;
            this.TextBoxOneBWhite.Text = "Text Box 1 To White";
            this.TextBoxOneBWhite.UseVisualStyleBackColor = true;
            this.TextBoxOneBWhite.Click += new System.EventHandler(this.TextBoxOneBWhite_Click_1);
            // 
            // RandomColorOfForm
            // 
            this.RandomColorOfForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomColorOfForm.Location = new System.Drawing.Point(111, 311);
            this.RandomColorOfForm.Name = "RandomColorOfForm";
            this.RandomColorOfForm.Size = new System.Drawing.Size(289, 49);
            this.RandomColorOfForm.TabIndex = 11;
            this.RandomColorOfForm.Text = "Change Form Background Color Randomly";
            this.RandomColorOfForm.UseVisualStyleBackColor = true;
            this.RandomColorOfForm.Click += new System.EventHandler(this.ChangeColorRandomly_Click);
            // 
            // ChangeTitle
            // 
            this.ChangeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTitle.Location = new System.Drawing.Point(111, 238);
            this.ChangeTitle.Name = "ChangeTitle";
            this.ChangeTitle.Size = new System.Drawing.Size(289, 49);
            this.ChangeTitle.TabIndex = 12;
            this.ChangeTitle.Text = "Take The Box1 Content As Form Title";
            this.ChangeTitle.UseVisualStyleBackColor = true;
            this.ChangeTitle.Click += new System.EventHandler(this.ChangeTitle_Click);
            this.ChangeTitle.MouseEnter += new System.EventHandler(this.ChangeTitle_Click);
            // 
            // ChangeLabel1
            // 
            this.ChangeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel1.Location = new System.Drawing.Point(1165, 81);
            this.ChangeLabel1.Name = "ChangeLabel1";
            this.ChangeLabel1.Size = new System.Drawing.Size(261, 58);
            this.ChangeLabel1.TabIndex = 13;
            this.ChangeLabel1.Text = "Change The Label";
            this.ChangeLabel1.UseVisualStyleBackColor = true;
            this.ChangeLabel1.Click += new System.EventHandler(this.ChangeLabel1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 7;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(418, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 49);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HideTextBoxOne
            // 
            this.HideTextBoxOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HideTextBoxOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideTextBoxOne.Location = new System.Drawing.Point(1165, 345);
            this.HideTextBoxOne.Name = "HideTextBoxOne";
            this.HideTextBoxOne.Size = new System.Drawing.Size(261, 58);
            this.HideTextBoxOne.TabIndex = 7;
            this.HideTextBoxOne.Text = "Hide Text Box 1";
            this.HideTextBoxOne.UseVisualStyleBackColor = false;
            this.HideTextBoxOne.AutoSizeChanged += new System.EventHandler(this.HideTextBoxOne_Click);
            this.HideTextBoxOne.Click += new System.EventHandler(this.HideTextBoxOne_Click);
            // 
            // EnableAll
            // 
            this.EnableAll.BackColor = System.Drawing.Color.Lime;
            this.EnableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableAll.Location = new System.Drawing.Point(1165, 464);
            this.EnableAll.Name = "EnableAll";
            this.EnableAll.Size = new System.Drawing.Size(261, 58);
            this.EnableAll.TabIndex = 8;
            this.EnableAll.Text = "Enable Text Box 1";
            this.EnableAll.UseVisualStyleBackColor = false;
            this.EnableAll.Visible = false;
            this.EnableAll.Click += new System.EventHandler(this.EnableAll_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Press The Button To Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Test Label ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Location = new System.Drawing.Point(1177, 200);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 84);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Pressing
            // 
            this.Pressing.Location = new System.Drawing.Point(432, 451);
            this.Pressing.Name = "Pressing";
            this.Pressing.Size = new System.Drawing.Size(261, 60);
            this.Pressing.TabIndex = 18;
            this.Pressing.Text = "button5";
            this.Pressing.UseVisualStyleBackColor = true;
            this.Pressing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WhenMousePressingTheButton);
            this.Pressing.MouseLeave += new System.EventHandler(this.MouseLeft);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 565);
            this.Controls.Add(this.Pressing);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnableBox);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ChangeLabel1);
            this.Controls.Add(this.ChangeTitle);
            this.Controls.Add(this.RandomColorOfForm);
            this.Controls.Add(this.TextBoxOneBWhite);
            this.Controls.Add(this.BoxOneToBRed);
            this.Controls.Add(this.EnableAll);
            this.Controls.Add(this.HideTextBoxOne);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Copy App BTW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Box1;
        private System.Windows.Forms.RichTextBox Box2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.Button EnableBox;
        private System.Windows.Forms.Button BoxOneToBRed;
        private System.Windows.Forms.Button TextBoxOneBWhite;
        private System.Windows.Forms.Button RandomColorOfForm;
        private System.Windows.Forms.Button ChangeTitle;
        private System.Windows.Forms.Button ChangeLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button HideTextBoxOne;
        private System.Windows.Forms.Button EnableAll;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Pressing;
    }
}

