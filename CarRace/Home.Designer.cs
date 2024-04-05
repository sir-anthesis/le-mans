namespace CarRace
{
    partial class Home
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
            this.btplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btplay
            // 
            this.btplay.Location = new System.Drawing.Point(29, 206);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(225, 44);
            this.btplay.TabIndex = 1;
            this.btplay.Text = "7";
            this.btplay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "PLAY";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "PLAY";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRace.Properties.Resources.bg1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.BackColor = System.Drawing.Color.White;
            this.lbuser.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbuser.Location = new System.Drawing.Point(23, 45);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(98, 31);
            this.lbuser.TabIndex = 5;
            this.lbuser.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(610, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coins :";
            // 
            // lbcoins
            // 
            this.lbcoins.AutoSize = true;
            this.lbcoins.BackColor = System.Drawing.Color.White;
            this.lbcoins.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoins.ForeColor = System.Drawing.Color.Gold;
            this.lbcoins.Location = new System.Drawing.Point(707, 45);
            this.lbcoins.Name = "lbcoins";
            this.lbcoins.Size = new System.Drawing.Size(57, 25);
            this.lbcoins.TabIndex = 7;
            this.lbcoins.Text = "999";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lbcoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btplay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcoins;
    }
}