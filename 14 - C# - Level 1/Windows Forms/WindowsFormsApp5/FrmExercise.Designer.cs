namespace WindowsFormsApp5
{
    partial class FrmExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercise));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBooks = new System.Windows.Forms.RadioButton();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.picTheViewer = new System.Windows.Forms.PictureBox();
            this.labIndicator = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTheViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBooks);
            this.groupBox1.Controls.Add(this.rbCat);
            this.groupBox1.Controls.Add(this.rbPen);
            this.groupBox1.Controls.Add(this.rbGirl);
            this.groupBox1.Controls.Add(this.rbBoy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbBooks
            // 
            this.rbBooks.AutoSize = true;
            this.rbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBooks.Location = new System.Drawing.Point(582, 33);
            this.rbBooks.Name = "rbBooks";
            this.rbBooks.Size = new System.Drawing.Size(82, 24);
            this.rbBooks.TabIndex = 4;
            this.rbBooks.TabStop = true;
            this.rbBooks.Tag = "C:\\Users\\wwwhd\\Downloads\\PicBooks .jpg";
            this.rbBooks.Text = "Books";
            this.rbBooks.UseVisualStyleBackColor = true;
            this.rbBooks.CheckedChanged += new System.EventHandler(this.UpdatePictureBox);
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCat.Location = new System.Drawing.Point(751, 33);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(59, 24);
            this.rbCat.TabIndex = 3;
            this.rbCat.TabStop = true;
            this.rbCat.Tag = "C:\\Users\\wwwhd\\Downloads\\closeup-shot-beautiful-ginger-domestic-kitten-sitting-wh" +
    "ite-surface.jpg";
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            this.rbCat.CheckedChanged += new System.EventHandler(this.UpdatePictureBox);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPen.Location = new System.Drawing.Point(409, 33);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(62, 24);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "C:\\Users\\wwwhd\\Downloads\\6d4099be-dc52-43a4-82ef-6e4bb36e436d.jpg";
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.UpdatePictureBox);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGirl.Location = new System.Drawing.Point(240, 33);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(61, 24);
            this.rbGirl.TabIndex = 1;
            this.rbGirl.TabStop = true;
            this.rbGirl.Tag = "C:\\Users\\wwwhd\\Downloads\\picGril.jpg";
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.UpdatePictureBox);
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoy.Location = new System.Drawing.Point(81, 33);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(65, 26);
            this.rbBoy.TabIndex = 0;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "C:\\Users\\wwwhd\\Downloads\\38459.jpg";
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.UpdatePictureBox);
            // 
            // picTheViewer
            // 
            this.picTheViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTheViewer.Cursor = System.Windows.Forms.Cursors.No;
            this.picTheViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTheViewer.Image = ((System.Drawing.Image)(resources.GetObject("picTheViewer.Image")));
            this.picTheViewer.Location = new System.Drawing.Point(0, 0);
            this.picTheViewer.Name = "picTheViewer";
            this.picTheViewer.Size = new System.Drawing.Size(1272, 416);
            this.picTheViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTheViewer.TabIndex = 1;
            this.picTheViewer.TabStop = false;
            // 
            // labIndicator
            // 
            this.labIndicator.Dock = System.Windows.Forms.DockStyle.Top;
            this.labIndicator.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIndicator.ForeColor = System.Drawing.Color.Red;
            this.labIndicator.Location = new System.Drawing.Point(0, 0);
            this.labIndicator.Name = "labIndicator";
            this.labIndicator.Size = new System.Drawing.Size(1272, 47);
            this.labIndicator.TabIndex = 0;
            this.labIndicator.Text = "label1";
            this.labIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 479);
            this.Controls.Add(this.labIndicator);
            this.Controls.Add(this.picTheViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExercise";
            this.Text = "FrmExercise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTheViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBooks;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.PictureBox picTheViewer;
        private System.Windows.Forms.Label labIndicator;
    }
}