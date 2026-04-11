namespace WindowsFormsApp10
{
    partial class Timer
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
            this.label3 = new System.Windows.Forms.Label();
            this.labMin = new System.Windows.Forms.Label();
            this.labSec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpDownSec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpDownHour = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMin.Location = new System.Drawing.Point(230, 118);
            this.labMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(71, 53);
            this.labMin.TabIndex = 5;
            this.labMin.Text = "00";
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSec.Location = new System.Drawing.Point(421, 118);
            this.labSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(71, 53);
            this.labSec.TabIndex = 4;
            this.labSec.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpDownMin
            // 
            this.UpDownMin.Location = new System.Drawing.Point(232, 236);
            this.UpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.UpDownMin.Name = "UpDownMin";
            this.UpDownMin.Size = new System.Drawing.Size(66, 28);
            this.UpDownMin.TabIndex = 7;
            this.UpDownMin.Tag = "Min";
            this.UpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownMin.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(227, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 39);
            this.label.TabIndex = 8;
            this.label.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sec";
            // 
            // UpDownSec
            // 
            this.UpDownSec.Location = new System.Drawing.Point(423, 236);
            this.UpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.UpDownSec.Name = "UpDownSec";
            this.UpDownSec.Size = new System.Drawing.Size(66, 28);
            this.UpDownSec.TabIndex = 10;
            this.UpDownSec.Tag = "Sec";
            this.UpDownSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownSec.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 53);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHour.Location = new System.Drawing.Point(46, 118);
            this.labHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(71, 53);
            this.labHour.TabIndex = 12;
            this.labHour.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hour";
            // 
            // UpDownHour
            // 
            this.UpDownHour.Location = new System.Drawing.Point(48, 236);
            this.UpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.UpDownHour.Name = "UpDownHour";
            this.UpDownHour.Size = new System.Drawing.Size(66, 28);
            this.UpDownHour.TabIndex = 14;
            this.UpDownHour.Tag = "Hour";
            this.UpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownHour.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("SF Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(26, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 49);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("SF Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(210, 302);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 49);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Transparent;
            this.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("SF Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(401, 302);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(111, 49);
            this.btnRest.TabIndex = 17;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 364);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.UpDownHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpDownSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.UpDownMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.labSec);
            this.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer App";
     
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown UpDownMin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UpDownHour;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRest;
    }
}