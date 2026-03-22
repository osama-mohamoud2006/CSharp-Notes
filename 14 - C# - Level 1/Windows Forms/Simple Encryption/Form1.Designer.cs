namespace Simple_Encryption
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
            this.button1 = new System.Windows.Forms.Button();
            this.EnteredByUser = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old Antic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(248, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple,Cringe Encryptor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(483, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Press The Button To Get Hacked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_Click);
            // 
            // EnteredByUser
            // 
            this.EnteredByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredByUser.Location = new System.Drawing.Point(108, 193);
            this.EnteredByUser.Name = "EnteredByUser";
            this.EnteredByUser.Size = new System.Drawing.Size(200, 45);
            this.EnteredByUser.TabIndex = 2;
            this.EnteredByUser.HideSelectionChanged += new System.EventHandler(this.Undo_Click);
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.HideSelection = false;
            this.Result.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Result.Location = new System.Drawing.Point(528, 193);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(199, 45);
            this.Result.TabIndex = 3;
            this.Result.ReadOnlyChanged += new System.EventHandler(this.button1_Click);
            this.Result.TabStopChanged += new System.EventHandler(this.button1_Click);
            this.Result.VisibleChanged += new System.EventHandler(this.button1_Click);
            this.Result.ParentChanged += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Your Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Res";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Undo
            // 
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.ForeColor = System.Drawing.Color.Red;
            this.Undo.Location = new System.Drawing.Point(317, 422);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(226, 38);
            this.Undo.TabIndex = 6;
            this.Undo.Text = "Press to undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.FontChanged += new System.EventHandler(this.button1_Click);
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 524);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EnteredByUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CringeEncryptionApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnteredByUser;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Undo;
    }
}

