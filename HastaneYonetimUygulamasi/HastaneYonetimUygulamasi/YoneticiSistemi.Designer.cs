namespace HastaneYonetimUygulamasi
{
    partial class YoneticiSistemi
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
            label1 = new Label();
            label2 = new Label();
            KullaniciAdTxt = new TextBox();
            SifreTxt = new TextBox();
            GirisYapBtn = new Button();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 120);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // KullaniciAdTxt
            // 
            KullaniciAdTxt.Location = new Point(179, 42);
            KullaniciAdTxt.Margin = new Padding(3, 4, 3, 4);
            KullaniciAdTxt.Name = "KullaniciAdTxt";
            KullaniciAdTxt.Size = new Size(140, 35);
            KullaniciAdTxt.TabIndex = 3;
            // 
            // SifreTxt
            // 
            SifreTxt.Location = new Point(179, 113);
            SifreTxt.Margin = new Padding(3, 4, 3, 4);
            SifreTxt.Name = "SifreTxt";
            SifreTxt.PasswordChar = '*';
            SifreTxt.Size = new Size(140, 35);
            SifreTxt.TabIndex = 4;
            // 
            // GirisYapBtn
            // 
            GirisYapBtn.Location = new Point(179, 184);
            GirisYapBtn.Margin = new Padding(3, 4, 3, 4);
            GirisYapBtn.Name = "GirisYapBtn";
            GirisYapBtn.Size = new Size(140, 41);
            GirisYapBtn.TabIndex = 5;
            GirisYapBtn.Text = "Giris Yap";
            GirisYapBtn.UseVisualStyleBackColor = true;
            GirisYapBtn.Click += GirisYapBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(366, 483);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 6;
            label3.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, -6);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 148);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir3;
            pictureBox1.Location = new Point(742, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Yu Gothic Medium", 24F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(279, 41);
            label4.Name = "label4";
            label4.Size = new Size(333, 52);
            label4.TabIndex = 0;
            label4.Text = "Yönetici Sistemi";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.images_5_;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-9, 133);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 574);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(GirisYapBtn);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(KullaniciAdTxt);
            panel3.Controls.Add(SifreTxt);
            panel3.Location = new Point(290, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 321);
            panel3.TabIndex = 7;
            // 
            // YoneticiSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 706);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "YoneticiSistemi";
            Text = "YoneticiSistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox KullaniciAdTxt;
        private TextBox SifreTxt;
        private Button GirisYapBtn;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}