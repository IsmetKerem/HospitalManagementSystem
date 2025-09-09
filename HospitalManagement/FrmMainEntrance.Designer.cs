namespace HospitalManagement
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
            this.btnHastaLogin = new System.Windows.Forms.Button();
            this.btnDoktorLogin = new System.Windows.Forms.Button();
            this.btnSekreterLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaLogin
            // 
            this.btnHastaLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaLogin.BackgroundImage")));
            this.btnHastaLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaLogin.Location = new System.Drawing.Point(40, 228);
            this.btnHastaLogin.Name = "btnHastaLogin";
            this.btnHastaLogin.Size = new System.Drawing.Size(251, 146);
            this.btnHastaLogin.TabIndex = 0;
            this.btnHastaLogin.UseVisualStyleBackColor = true;
            this.btnHastaLogin.Click += new System.EventHandler(this.btnHastaLogin_Click);
            // 
            // btnDoktorLogin
            // 
            this.btnDoktorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorLogin.BackgroundImage")));
            this.btnDoktorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorLogin.Location = new System.Drawing.Point(319, 228);
            this.btnDoktorLogin.Name = "btnDoktorLogin";
            this.btnDoktorLogin.Size = new System.Drawing.Size(251, 146);
            this.btnDoktorLogin.TabIndex = 1;
            this.btnDoktorLogin.UseVisualStyleBackColor = true;
            this.btnDoktorLogin.Click += new System.EventHandler(this.btnDoktorLogin_Click);
            // 
            // btnSekreterLogin
            // 
            this.btnSekreterLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterLogin.BackgroundImage")));
            this.btnSekreterLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterLogin.Location = new System.Drawing.Point(603, 228);
            this.btnSekreterLogin.Name = "btnSekreterLogin";
            this.btnSekreterLogin.Size = new System.Drawing.Size(251, 146);
            this.btnSekreterLogin.TabIndex = 2;
            this.btnSekreterLogin.UseVisualStyleBackColor = true;
            this.btnSekreterLogin.Click += new System.EventHandler(this.btnSekreterLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sekreter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(638, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 150);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(283, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 194);
            this.label4.TabIndex = 7;
            this.label4.Text = "See Blue\r\n Hospital";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(58, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 150);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterLogin);
            this.Controls.Add(this.btnDoktorLogin);
            this.Controls.Add(this.btnHastaLogin);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hospital Panel Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaLogin;
        private System.Windows.Forms.Button btnDoktorLogin;
        private System.Windows.Forms.Button btnSekreterLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

