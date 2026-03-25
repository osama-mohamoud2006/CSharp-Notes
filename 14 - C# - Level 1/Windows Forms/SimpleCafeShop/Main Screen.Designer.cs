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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEsp = new System.Windows.Forms.Button();
            this.btnMatcha = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(570, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Khara Cofe";
            // 
            // labCoffe
            // 
            this.labCoffe.BackColor = System.Drawing.Color.Transparent;
            this.labCoffe.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCoffe.Location = new System.Drawing.Point(197, 141);
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
            this.labEspresso.Location = new System.Drawing.Point(197, 263);
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
            this.labMatcha.Location = new System.Drawing.Point(197, 385);
            this.labMatcha.Name = "labMatcha";
            this.labMatcha.Size = new System.Drawing.Size(150, 50);
            this.labMatcha.TabIndex = 3;
            this.labMatcha.Text = "Matcha";
            this.labMatcha.MouseEnter += new System.EventHandler(this.MatchaEnter);
            this.labMatcha.MouseLeave += new System.EventHandler(this.MatchLeft);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.MouseEnter += new System.EventHandler(this.MouseEnteredCoffee);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.MouseEnter += new System.EventHandler(this.MouseEnteredCoffee);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(713, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            this.label7.MouseEnter += new System.EventHandler(this.MouseEnteredCoffee);
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.Location = new System.Drawing.Point(1160, 185);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(245, 218);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "price";
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.Transparent;
            this.btnCoffee.FlatAppearance.BorderSize = 2;
            this.btnCoffee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(441, 148);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(141, 36);
            this.btnCoffee.TabIndex = 8;
            this.btnCoffee.Text = "30$";
            this.btnCoffee.UseVisualStyleBackColor = false;

            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(858, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEsp
            // 
            this.btnEsp.BackColor = System.Drawing.Color.Transparent;
            this.btnEsp.FlatAppearance.BorderSize = 2;
            this.btnEsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsp.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsp.Location = new System.Drawing.Point(441, 270);
            this.btnEsp.Name = "btnEsp";
            this.btnEsp.Size = new System.Drawing.Size(141, 36);
            this.btnEsp.TabIndex = 9;
            this.btnEsp.Text = "60$";
            this.btnEsp.UseVisualStyleBackColor = false;
     
            this.btnEsp.MouseEnter += new System.EventHandler(this.MouseEnteredEsp);
            // 
            // btnMatcha
            // 
            this.btnMatcha.BackColor = System.Drawing.Color.Transparent;
            this.btnMatcha.FlatAppearance.BorderSize = 2;
            this.btnMatcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMatcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatcha.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatcha.Location = new System.Drawing.Point(441, 392);
            this.btnMatcha.Name = "btnMatcha";
            this.btnMatcha.Size = new System.Drawing.Size(141, 36);
            this.btnMatcha.TabIndex = 10;
            this.btnMatcha.Text = "70$";
            this.btnMatcha.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(858, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(858, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1566, 547);
            this.Controls.Add(this.btnMatcha);
            this.Controls.Add(this.btnEsp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCoffe;
        private System.Windows.Forms.Label labEspresso;
        private System.Windows.Forms.Label labMatcha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEsp;
        private System.Windows.Forms.Button btnMatcha;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}