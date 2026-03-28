namespace WindowsFormsApp
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbDisableAll = new System.Windows.Forms.CheckBox();
            this.cbEnableAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1099, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(250, 50);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(1099, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 50);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "txt";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbDisableAll
            // 
            this.cbDisableAll.AutoSize = true;
            this.cbDisableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisableAll.Location = new System.Drawing.Point(1099, 218);
            this.cbDisableAll.Name = "cbDisableAll";
            this.cbDisableAll.Size = new System.Drawing.Size(230, 50);
            this.cbDisableAll.TabIndex = 2;
            this.cbDisableAll.Text = "DisableAll";
            this.cbDisableAll.UseVisualStyleBackColor = true;
            this.cbDisableAll.CheckedChanged += new System.EventHandler(this.cbDisableAll_CheckedChanged);
            // 
            // cbEnableAll
            // 
            this.cbEnableAll.AutoSize = true;
            this.cbEnableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableAll.Location = new System.Drawing.Point(1099, 343);
            this.cbEnableAll.Name = "cbEnableAll";
            this.cbEnableAll.Size = new System.Drawing.Size(220, 50);
            this.cbEnableAll.TabIndex = 3;
            this.cbEnableAll.Text = "EnableAll";
            this.cbEnableAll.ThreeState = true;
            this.cbEnableAll.UseVisualStyleBackColor = true;
            this.cbEnableAll.CheckedChanged += new System.EventHandler(this.cbEnableAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 538);
            this.Controls.Add(this.cbEnableAll);
            this.Controls.Add(this.cbDisableAll);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbDisableAll;
        private System.Windows.Forms.CheckBox cbEnableAll;
    }
}

