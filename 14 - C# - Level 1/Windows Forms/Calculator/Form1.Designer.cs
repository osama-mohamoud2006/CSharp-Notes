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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Black = new System.Windows.Forms.Button();
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
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
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
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 657);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button Black;
    }
}

