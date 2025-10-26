namespace HastaneYonetimUygulamasi
{
    partial class DoktorSistemi
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
            label3 = new Label();
            DoktorAdTxt = new TextBox();
            DoktorSoyadTxt = new TextBox();
            DoktorTctxt = new TextBox();
            DoktorKayitBtn = new Button();
            DoktorGrsBtn = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(92, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(65, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(95, 173);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // DoktorAdTxt
            // 
            DoktorAdTxt.Location = new Point(164, 37);
            DoktorAdTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorAdTxt.Name = "DoktorAdTxt";
            DoktorAdTxt.Size = new Size(140, 35);
            DoktorAdTxt.TabIndex = 3;
            // 
            // DoktorSoyadTxt
            // 
            DoktorSoyadTxt.Location = new Point(164, 99);
            DoktorSoyadTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorSoyadTxt.Name = "DoktorSoyadTxt";
            DoktorSoyadTxt.Size = new Size(140, 35);
            DoktorSoyadTxt.TabIndex = 4;
            // 
            // DoktorTctxt
            // 
            DoktorTctxt.Location = new Point(164, 166);
            DoktorTctxt.Margin = new Padding(3, 4, 3, 4);
            DoktorTctxt.Name = "DoktorTctxt";
            DoktorTctxt.Size = new Size(140, 35);
            DoktorTctxt.TabIndex = 5;
            // 
            // DoktorKayitBtn
            // 
            DoktorKayitBtn.Location = new Point(14, 267);
            DoktorKayitBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorKayitBtn.Name = "DoktorKayitBtn";
            DoktorKayitBtn.Size = new Size(180, 80);
            DoktorKayitBtn.TabIndex = 6;
            DoktorKayitBtn.Text = "Kayit ol";
            DoktorKayitBtn.UseVisualStyleBackColor = true;
            DoktorKayitBtn.Click += DoktorKayitBtn_Click;
            // 
            // DoktorGrsBtn
            // 
            DoktorGrsBtn.Location = new Point(251, 267);
            DoktorGrsBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorGrsBtn.Name = "DoktorGrsBtn";
            DoktorGrsBtn.Size = new Size(185, 80);
            DoktorGrsBtn.TabIndex = 7;
            DoktorGrsBtn.Text = "Giriş Yap";
            DoktorGrsBtn.UseVisualStyleBackColor = true;
            DoktorGrsBtn.Click += DoktorGrsBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 140);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Font = new Font("Yu Gothic Medium", 24F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(359, 42);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(387, 52);
            label4.TabIndex = 0;
            label4.Text = "Doktor Giriş Paneli";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(DoktorAdTxt);
            panel2.Controls.Add(DoktorGrsBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(DoktorKayitBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DoktorTctxt);
            panel2.Controls.Add(DoktorSoyadTxt);
            panel2.Location = new Point(334, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 496);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir__1_;
            pictureBox1.Location = new Point(874, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DoktorSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImage = Properties.Resources.images2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1057, 684);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoktorSistemi";
            Text = "DoktorSistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DoktorAdTxt;
        private TextBox DoktorSoyadTxt;
        private TextBox DoktorTctxt;
        private Button DoktorKayitBtn;
        private Button DoktorGrsBtn;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}