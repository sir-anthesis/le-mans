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
            this.lbuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcoins = new System.Windows.Forms.Label();
            this.btplay = new System.Windows.Forms.Button();
            this.btgrg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pccar = new System.Windows.Forms.PictureBox();
            this.btlogout = new System.Windows.Forms.Button();
            this.btldb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccar)).BeginInit();
            this.SuspendLayout();
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
            // btplay
            // 
            this.btplay.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btplay.Location = new System.Drawing.Point(12, 195);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(289, 34);
            this.btplay.TabIndex = 8;
            this.btplay.Text = "PLAY";
            this.btplay.UseVisualStyleBackColor = true;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // btgrg
            // 
            this.btgrg.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgrg.Location = new System.Drawing.Point(12, 256);
            this.btgrg.Name = "btgrg";
            this.btgrg.Size = new System.Drawing.Size(289, 34);
            this.btgrg.TabIndex = 9;
            this.btgrg.Text = "GARAGE";
            this.btgrg.UseVisualStyleBackColor = true;
            this.btgrg.Click += new System.EventHandler(this.btgrg_Click);
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
            // pccar
            // 
            this.pccar.BackColor = System.Drawing.Color.Black;
            this.pccar.Image = global::CarRace.Properties.Resources.cr1;
            this.pccar.Location = new System.Drawing.Point(518, 325);
            this.pccar.Name = "pccar";
            this.pccar.Size = new System.Drawing.Size(343, 167);
            this.pccar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pccar.TabIndex = 10;
            this.pccar.TabStop = false;
            // 
            // btlogout
            // 
            this.btlogout.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.Location = new System.Drawing.Point(12, 488);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(289, 34);
            this.btlogout.TabIndex = 11;
            this.btlogout.Text = "LOGOUT";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btldb
            // 
            this.btldb.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btldb.Location = new System.Drawing.Point(12, 312);
            this.btldb.Name = "btldb";
            this.btldb.Size = new System.Drawing.Size(289, 34);
            this.btldb.TabIndex = 12;
            this.btldb.Text = "LEADERBOARD";
            this.btldb.UseVisualStyleBackColor = true;
            this.btldb.Click += new System.EventHandler(this.btldb_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btldb);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.pccar);
            this.Controls.Add(this.btgrg);
            this.Controls.Add(this.btplay);
            this.Controls.Add(this.lbcoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcoins;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btgrg;
        private System.Windows.Forms.PictureBox pccar;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btldb;
    }
}