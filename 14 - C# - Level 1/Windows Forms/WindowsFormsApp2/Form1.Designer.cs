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
            this.label1 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.RichTextBox();
            this.Box2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.EnableBox = new System.Windows.Forms.Button();
            this.HideTextBoxOne = new System.Windows.Forms.Button();
            this.EnableAll = new System.Windows.Forms.Button();
            this.BoxOneToBRed = new System.Windows.Forms.Button();
            this.TextBoxOneBWhite = new System.Windows.Forms.Button();
            this.RandomColorOfForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Copy";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(146, 130);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(226, 75);
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
            this.button1.Location = new System.Drawing.Point(425, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Press The Button To Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Enabled = false;
            this.DisableButton.Location = new System.Drawing.Point(425, 387);
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
            this.EnableBox.Location = new System.Drawing.Point(425, 453);
            this.EnableBox.Name = "EnableBox";
            this.EnableBox.Size = new System.Drawing.Size(261, 60);
            this.EnableBox.TabIndex = 6;
            this.EnableBox.Text = "Enable Text Box 1";
            this.EnableBox.UseVisualStyleBackColor = true;
            this.EnableBox.Click += new System.EventHandler(this.EnableBox_Click);
            // 
            // HideTextBoxOne
            // 
            this.HideTextBoxOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HideTextBoxOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideTextBoxOne.Location = new System.Drawing.Point(759, 404);
            this.HideTextBoxOne.Name = "HideTextBoxOne";
            this.HideTextBoxOne.Size = new System.Drawing.Size(251, 43);
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
            this.EnableAll.Location = new System.Drawing.Point(759, 470);
            this.EnableAll.Name = "EnableAll";
            this.EnableAll.Size = new System.Drawing.Size(251, 43);
            this.EnableAll.TabIndex = 8;
            this.EnableAll.Text = "Enable Text Box 1";
            this.EnableAll.UseVisualStyleBackColor = false;
            this.EnableAll.Visible = false;
            this.EnableAll.Click += new System.EventHandler(this.EnableAll_Click);
            // 
            // BoxOneToBRed
            // 
            this.BoxOneToBRed.Location = new System.Drawing.Point(163, 392);
            this.BoxOneToBRed.Name = "BoxOneToBRed";
            this.BoxOneToBRed.Size = new System.Drawing.Size(224, 55);
            this.BoxOneToBRed.TabIndex = 9;
            this.BoxOneToBRed.Text = "Text Box 1 To Red";
            this.BoxOneToBRed.UseVisualStyleBackColor = true;
            this.BoxOneToBRed.Click += new System.EventHandler(this.BoxOneToBRed_Click);
            // 
            // TextBoxOneBWhite
            // 
            this.TextBoxOneBWhite.Location = new System.Drawing.Point(163, 464);
            this.TextBoxOneBWhite.Name = "TextBoxOneBWhite";
            this.TextBoxOneBWhite.Size = new System.Drawing.Size(224, 55);
            this.TextBoxOneBWhite.TabIndex = 10;
            this.TextBoxOneBWhite.Text = "Text Box 1 To White";
            this.TextBoxOneBWhite.UseVisualStyleBackColor = true;
            this.TextBoxOneBWhite.Click += new System.EventHandler(this.TextBoxOneBWhite_Click_1);
            // 
            // RandomColorOfForm
            // 
            this.RandomColorOfForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomColorOfForm.Location = new System.Drawing.Point(98, 311);
            this.RandomColorOfForm.Name = "RandomColorOfForm";
            this.RandomColorOfForm.Size = new System.Drawing.Size(321, 53);
            this.RandomColorOfForm.TabIndex = 11;
            this.RandomColorOfForm.Text = "Change Form Background Color Randomly";
            this.RandomColorOfForm.UseVisualStyleBackColor = true;
            this.RandomColorOfForm.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 565);
            this.Controls.Add(this.RandomColorOfForm);
            this.Controls.Add(this.TextBoxOneBWhite);
            this.Controls.Add(this.BoxOneToBRed);
            this.Controls.Add(this.EnableAll);
            this.Controls.Add(this.HideTextBoxOne);
            this.Controls.Add(this.EnableBox);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Box1;
        private System.Windows.Forms.RichTextBox Box2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.Button EnableBox;
        private System.Windows.Forms.Button HideTextBoxOne;
        private System.Windows.Forms.Button EnableAll;
        private System.Windows.Forms.Button BoxOneToBRed;
        private System.Windows.Forms.Button TextBoxOneBWhite;
        private System.Windows.Forms.Button RandomColorOfForm;
    }
}

