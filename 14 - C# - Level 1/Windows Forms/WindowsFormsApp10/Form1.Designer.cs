namespace WindowsFormsApp10
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
            this.components = new System.ComponentModel.Container();
            this.Sec = new System.Windows.Forms.Timer(this.components);
            this.labSec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Timer(this.components);
            this.Hour = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Sec
            // 
            this.Sec.Interval = 1000;
            this.Sec.Tick += new System.EventHandler(this.Sec_Tick);
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSec.Location = new System.Drawing.Point(178, 112);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(56, 62);
            this.labSec.TabIndex = 0;
            this.labSec.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PT Bold Arch", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(433, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "End";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMin.Location = new System.Drawing.Point(351, 112);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(56, 62);
            this.labMin.TabIndex = 3;
            this.labMin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Bold Arch", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(262, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 106);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Bold Arch", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(439, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 106);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHour.Location = new System.Drawing.Point(538, 112);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(56, 62);
            this.labHour.TabIndex = 6;
            this.labHour.Text = "0";
            this.labHour.Click += new System.EventHandler(this.labHour_Click);
            // 
            // Min
            // 
            this.Min.Interval = 60000;
            this.Min.Tick += new System.EventHandler(this.Min_Tick);
            // 
            // Hour
            // 
            this.Hour.Interval = 3600000;
            this.Hour.Tick += new System.EventHandler(this.Hour_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Sec;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.Timer Min;
        private System.Windows.Forms.Timer Hour;
    }
}

