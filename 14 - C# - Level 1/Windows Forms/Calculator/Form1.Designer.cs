namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.DeepGreen = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Bisque = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.RichTextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Black = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.DeleteLast = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeepGreen
            // 
            this.DeepGreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeepGreen.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.DeepGreen.Location = new System.Drawing.Point(444, 12);
            this.DeepGreen.Name = "DeepGreen";
            this.DeepGreen.Size = new System.Drawing.Size(55, 26);
            this.DeepGreen.TabIndex = 8;
            this.DeepGreen.UseVisualStyleBackColor = false;
            this.DeepGreen.Click += new System.EventHandler(this.DeepGreen_Click);
            // 
            // Blue
            // 
            this.Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Blue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Blue.Location = new System.Drawing.Point(588, 12);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(55, 26);
            this.Blue.TabIndex = 5;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Bisque
            // 
            this.Bisque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bisque.BackColor = System.Drawing.Color.Bisque;
            this.Bisque.Location = new System.Drawing.Point(517, 12);
            this.Bisque.Name = "Bisque";
            this.Bisque.Size = new System.Drawing.Size(55, 26);
            this.Bisque.TabIndex = 9;
            this.Bisque.UseVisualStyleBackColor = false;
            this.Bisque.Click += new System.EventHandler(this.Bisque_Click);
            // 
            // Screen
            // 
            this.Screen.Enabled = false;
            this.Screen.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(12, 47);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(621, 96);
            this.Screen.TabIndex = 10;
            this.Screen.Text = "";
            this.Screen.TextChanged += new System.EventHandler(this.Screen_TextChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 21);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(76, 23);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.Text = "Results :";
            // 
            // Black
            // 
            this.Black.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(367, 12);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(55, 26);
            this.Black.TabIndex = 12;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.Location = new System.Drawing.Point(412, 304);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(42, 44);
            this.Multi.TabIndex = 13;
            this.Multi.Text = "X";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.Location = new System.Drawing.Point(537, 304);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(42, 44);
            this.Div.TabIndex = 14;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(36, 188);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(52, 47);
            this.One.TabIndex = 15;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(136, 188);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(52, 47);
            this.Two.TabIndex = 16;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(227, 188);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(52, 47);
            this.Three.TabIndex = 17;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(36, 278);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(52, 47);
            this.Four.TabIndex = 18;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(136, 278);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(52, 47);
            this.Five.TabIndex = 19;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(227, 278);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(52, 47);
            this.Six.TabIndex = 20;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(35, 377);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(52, 47);
            this.Seven.TabIndex = 21;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(136, 377);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(52, 47);
            this.Eight.TabIndex = 22;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(227, 374);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(52, 47);
            this.Nine.TabIndex = 23;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(30, 457);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(57, 47);
            this.Zero.TabIndex = 24;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(213, 460);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(138, 47);
            this.Equal.TabIndex = 25;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // DeleteLast
            // 
            this.DeleteLast.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLast.ForeColor = System.Drawing.Color.White;
            this.DeleteLast.Location = new System.Drawing.Point(403, 208);
            this.DeleteLast.Name = "DeleteLast";
            this.DeleteLast.Size = new System.Drawing.Size(96, 46);
            this.DeleteLast.TabIndex = 26;
            this.DeleteLast.Text = "DEL";
            this.DeleteLast.UseVisualStyleBackColor = false;
            this.DeleteLast.Click += new System.EventHandler(this.DeleteLast_Click);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.SystemColors.Highlight;
            this.AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC.ForeColor = System.Drawing.Color.White;
            this.AC.Location = new System.Drawing.Point(526, 208);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(96, 46);
            this.AC.TabIndex = 27;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(412, 374);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(42, 44);
            this.Add.TabIndex = 28;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(537, 374);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(42, 44);
            this.Sub.TabIndex = 29;
            this.Sub.Text = "---";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Back Button Icons", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(136, 457);
            this.Dot.Margin = new System.Windows.Forms.Padding(30);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(44, 44);
            this.Dot.TabIndex = 30;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Ans
            // 
            this.Ans.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ans.Font = new System.Drawing.Font("Nirmala Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(434, 460);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(138, 57);
            this.Ans.TabIndex = 31;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = false;
            this.Ans.Visible = false;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.DeleteLast);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Bisque);
            this.Controls.Add(this.DeepGreen);
            this.Controls.Add(this.Blue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeepGreen;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Bisque;
        private System.Windows.Forms.RichTextBox Screen;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button DeleteLast;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Ans;
    }
}

