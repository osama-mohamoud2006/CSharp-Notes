namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(621, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi Bro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStartForm1
            // 
            this.btnStartForm1.BackColor = System.Drawing.Color.Transparent;
            this.btnStartForm1.FlatAppearance.BorderSize = 0;
            this.btnStartForm1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartForm1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartForm1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartForm1.ForeColor = System.Drawing.Color.Transparent;
            this.btnStartForm1.Location = new System.Drawing.Point(621, 320);
            this.btnStartForm1.Name = "btnStartForm1";
            this.btnStartForm1.Size = new System.Drawing.Size(290, 74);
            this.btnStartForm1.TabIndex = 1;
            this.btnStartForm1.Text = "Click Here ";
            this.btnStartForm1.UseVisualStyleBackColor = false;
            this.btnStartForm1.Click += new System.EventHandler(this.btnStartForm1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1560, 517);
            this.Controls.Add(this.btnStartForm1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form2";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartForm1;
    }
}