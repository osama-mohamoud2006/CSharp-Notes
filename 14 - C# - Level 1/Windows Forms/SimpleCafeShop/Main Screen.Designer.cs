namespace SimpleCafeShop
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.labCoffe = new System.Windows.Forms.Label();
            this.labEspresso = new System.Windows.Forms.Label();
            this.labMatcha = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnEsp = new System.Windows.Forms.Button();
            this.btnMatcha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.btnCoffeeUndo = new System.Windows.Forms.Button();
            this.btnEspUndo = new System.Windows.Forms.Button();
            this.btnMatchaUndo = new System.Windows.Forms.Button();
            this.labSummary = new System.Windows.Forms.Label();
            this.txtboxSummary = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(533, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Khara Cofe";
            // 
            // labCoffe
            // 
            this.labCoffe.BackColor = System.Drawing.Color.Transparent;
            this.labCoffe.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCoffe.Location = new System.Drawing.Point(63, 135);
            this.labCoffe.Name = "labCoffe";
            this.labCoffe.Size = new System.Drawing.Size(137, 50);
            this.labCoffe.TabIndex = 1;
            this.labCoffe.Text = "Coffee";
            this.labCoffe.MouseEnter += new System.EventHandler(this.MouseEnteredCoffee);
            this.labCoffe.MouseLeave += new System.EventHandler(this.MouseLeftCoffee);
            // 
            // labEspresso
            // 
            this.labEspresso.BackColor = System.Drawing.Color.Transparent;
            this.labEspresso.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspresso.Location = new System.Drawing.Point(63, 257);
            this.labEspresso.Name = "labEspresso";
            this.labEspresso.Size = new System.Drawing.Size(159, 50);
            this.labEspresso.TabIndex = 2;
            this.labEspresso.Text = "Espresso";
            this.labEspresso.MouseEnter += new System.EventHandler(this.MouseEnteredEsp);
            this.labEspresso.MouseLeave += new System.EventHandler(this.EspLeft);
            // 
            // labMatcha
            // 
            this.labMatcha.BackColor = System.Drawing.Color.Transparent;
            this.labMatcha.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatcha.Location = new System.Drawing.Point(63, 379);
            this.labMatcha.Name = "labMatcha";
            this.labMatcha.Size = new System.Drawing.Size(150, 50);
            this.labMatcha.TabIndex = 3;
            this.labMatcha.Text = "Matcha";
            this.labMatcha.MouseEnter += new System.EventHandler(this.MatchaEnter);
            this.labMatcha.MouseLeave += new System.EventHandler(this.MatchLeft);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.Transparent;
            this.btnCoffee.FlatAppearance.BorderSize = 2;
            this.btnCoffee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(308, 133);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(158, 54);
            this.btnCoffee.TabIndex = 2;
            this.btnCoffee.Text = "30$";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            this.btnCoffee.MouseEnter += new System.EventHandler(this.MouseEnteredbtnCoffee);
            this.btnCoffee.MouseLeave += new System.EventHandler(this.MouseLeftbtnCoffee);
            // 
            // btnEsp
            // 
            this.btnEsp.BackColor = System.Drawing.Color.Transparent;
            this.btnEsp.FlatAppearance.BorderSize = 2;
            this.btnEsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsp.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsp.Location = new System.Drawing.Point(308, 255);
            this.btnEsp.Name = "btnEsp";
            this.btnEsp.Size = new System.Drawing.Size(158, 54);
            this.btnEsp.TabIndex = 3;
            this.btnEsp.Text = "60$";
            this.btnEsp.UseVisualStyleBackColor = false;
            this.btnEsp.Click += new System.EventHandler(this.btnEsp_Click);
            this.btnEsp.MouseEnter += new System.EventHandler(this.MouseEnterbtnEsp);
            this.btnEsp.MouseLeave += new System.EventHandler(this.MouseLeftEsp);
            // 
            // btnMatcha
            // 
            this.btnMatcha.BackColor = System.Drawing.Color.Transparent;
            this.btnMatcha.FlatAppearance.BorderSize = 2;
            this.btnMatcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMatcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatcha.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatcha.Location = new System.Drawing.Point(308, 377);
            this.btnMatcha.Name = "btnMatcha";
            this.btnMatcha.Size = new System.Drawing.Size(158, 54);
            this.btnMatcha.TabIndex = 4;
            this.btnMatcha.Text = "70$";
            this.btnMatcha.UseVisualStyleBackColor = false;
            this.btnMatcha.Click += new System.EventHandler(this.btnMatcha_Click);
            this.btnMatcha.MouseEnter += new System.EventHandler(this.MouseEnteredbtnMatcha);
            this.btnMatcha.MouseLeave += new System.EventHandler(this.MouseLeftbtnMatcha);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 79);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Price";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.Location = new System.Drawing.Point(835, 405);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(57, 57);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "0";
            // 
            // btnUndo1
            // 
            this.btnCoffeeUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnCoffeeUndo.Enabled = false;
            this.btnCoffeeUndo.FlatAppearance.BorderSize = 2;
            this.btnCoffeeUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCoffeeUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeUndo.Location = new System.Drawing.Point(500, 133);
            this.btnCoffeeUndo.Name = "btnUndo1";
            this.btnCoffeeUndo.Size = new System.Drawing.Size(63, 52);
            this.btnCoffeeUndo.TabIndex = 13;
            this.btnCoffeeUndo.Text = "Undo";
            this.btnCoffeeUndo.UseVisualStyleBackColor = false;
            this.btnCoffeeUndo.Click += new System.EventHandler(this.UndoCoffeeOrder_Click);
            // 
            // btnEspUndo
            // 
            this.btnEspUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnEspUndo.Enabled = false;
            this.btnEspUndo.FlatAppearance.BorderSize = 2;
            this.btnEspUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEspUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspUndo.Location = new System.Drawing.Point(500, 255);
            this.btnEspUndo.Name = "btnEspUndo";
            this.btnEspUndo.Size = new System.Drawing.Size(63, 52);
            this.btnEspUndo.TabIndex = 14;
            this.btnEspUndo.Text = "Undo";
            this.btnEspUndo.UseVisualStyleBackColor = false;
            this.btnEspUndo.Click += new System.EventHandler(this.EspUndoOrder_Click);
            // 
            // btnMatchaUndo
            // 
            this.btnMatchaUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnMatchaUndo.Enabled = false;
            this.btnMatchaUndo.FlatAppearance.BorderSize = 2;
            this.btnMatchaUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMatchaUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchaUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchaUndo.Location = new System.Drawing.Point(500, 377);
            this.btnMatchaUndo.Name = "btnMatchaUndo";
            this.btnMatchaUndo.Size = new System.Drawing.Size(63, 52);
            this.btnMatchaUndo.TabIndex = 15;
            this.btnMatchaUndo.Text = "Undo";
            this.btnMatchaUndo.UseVisualStyleBackColor = false;
            this.btnMatchaUndo.Click += new System.EventHandler(this.MatchUndoOrder_Click);
            // 
            // labSummary
            // 
            this.labSummary.AutoSize = true;
            this.labSummary.BackColor = System.Drawing.Color.Transparent;
            this.labSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labSummary.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSummary.Location = new System.Drawing.Point(1265, 34);
            this.labSummary.Name = "labSummary";
            this.labSummary.Size = new System.Drawing.Size(269, 36);
            this.labSummary.TabIndex = 17;
            this.labSummary.Text = "Order Summary";
            // 
            // txtboxSummary
            // 
            this.txtboxSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSummary.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSummary.Enabled = false;
            this.txtboxSummary.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSummary.Location = new System.Drawing.Point(1281, 92);
            this.txtboxSummary.Name = "txtboxSummary";
            this.txtboxSummary.Size = new System.Drawing.Size(242, 355);
            this.txtboxSummary.TabIndex = 18;
            this.txtboxSummary.Text = "";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1566, 547);
            this.Controls.Add(this.txtboxSummary);
            this.Controls.Add(this.labSummary);
            this.Controls.Add(this.btnMatchaUndo);
            this.Controls.Add(this.btnEspUndo);
            this.Controls.Add(this.btnCoffeeUndo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMatcha);
            this.Controls.Add(this.btnEsp);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labMatcha);
            this.Controls.Add(this.labEspresso);
            this.Controls.Add(this.labCoffe);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCoffe;
        private System.Windows.Forms.Label labEspresso;
        private System.Windows.Forms.Label labMatcha;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnEsp;
        private System.Windows.Forms.Button btnMatcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Button btnCoffeeUndo;
        private System.Windows.Forms.Button btnEspUndo;
        private System.Windows.Forms.Button btnMatchaUndo;
        private System.Windows.Forms.Label labSummary;
        private System.Windows.Forms.RichTextBox txtboxSummary;
    }
}