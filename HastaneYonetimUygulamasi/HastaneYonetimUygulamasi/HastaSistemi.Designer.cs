namespace HastaneYonetimUygulamasi
{
    partial class HastaSistemi
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
            HastaKayitlBtn = new Button();
            HastaGrsBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HastaAdTxt = new TextBox();
            HastaSydTxt = new TextBox();
            HastaTcTxt = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // HastaKayitlBtn
            // 
            HastaKayitlBtn.Location = new Point(51, 244);
            HastaKayitlBtn.Margin = new Padding(3, 4, 3, 4);
            HastaKayitlBtn.Name = "HastaKayitlBtn";
            HastaKayitlBtn.Size = new Size(157, 79);
            HastaKayitlBtn.TabIndex = 0;
            HastaKayitlBtn.Text = "Hastaneye kayit ol";
            HastaKayitlBtn.UseVisualStyleBackColor = true;
            HastaKayitlBtn.Click += HastaKayitlBtn_Click;
            // 
            // HastaGrsBtn
            // 
            HastaGrsBtn.Location = new Point(240, 244);
            HastaGrsBtn.Margin = new Padding(3, 4, 3, 4);
            HastaGrsBtn.Name = "HastaGrsBtn";
            HastaGrsBtn.Size = new Size(157, 79);
            HastaGrsBtn.TabIndex = 1;
            HastaGrsBtn.Text = "Giriş Yap";
            HastaGrsBtn.UseVisualStyleBackColor = true;
            HastaGrsBtn.Click += HastaGrsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 47);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 2;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 162);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 4;
            label3.Text = "TC:";
            // 
            // HastaAdTxt
            // 
            HastaAdTxt.Location = new Point(138, 40);
            HastaAdTxt.Margin = new Padding(3, 4, 3, 4);
            HastaAdTxt.Name = "HastaAdTxt";
            HastaAdTxt.Size = new Size(230, 35);
            HastaAdTxt.TabIndex = 5;
            // 
            // HastaSydTxt
            // 
            HastaSydTxt.Location = new Point(138, 97);
            HastaSydTxt.Margin = new Padding(3, 4, 3, 4);
            HastaSydTxt.Name = "HastaSydTxt";
            HastaSydTxt.Size = new Size(230, 35);
            HastaSydTxt.TabIndex = 6;
            // 
            // HastaTcTxt
            // 
            HastaTcTxt.Location = new Point(138, 155);
            HastaTcTxt.Margin = new Padding(3, 4, 3, 4);
            HastaTcTxt.Name = "HastaTcTxt";
            HastaTcTxt.Size = new Size(230, 35);
            HastaTcTxt.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-6, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 122);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir;
            pictureBox1.Location = new Point(907, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Font = new Font("Yu Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 43);
            label4.Name = "label4";
            label4.Size = new Size(370, 52);
            label4.TabIndex = 0;
            label4.Text = "Hasta Giriş Paneli";
            // 
            // panel2
            // 
            panel2.Controls.Add(HastaAdTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(HastaKayitlBtn);
            panel2.Controls.Add(HastaGrsBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(HastaTcTxt);
            panel2.Controls.Add(HastaSydTxt);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(341, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 374);
            panel2.TabIndex = 9;
            // 
            // HastaSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HastaSistemi";
            Text = "HastaSistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button HastaKayitlBtn;
        private Button HastaGrsBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox HastaAdTxt;
        private TextBox HastaSydTxt;
        private TextBox HastaTcTxt;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}