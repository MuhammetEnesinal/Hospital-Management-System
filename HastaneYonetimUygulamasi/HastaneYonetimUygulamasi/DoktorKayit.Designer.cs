namespace HastaneYonetimUygulamasi
{
    partial class DoktorKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorKayit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DoktorAdTxt = new TextBox();
            DoktorSydTxt = new TextBox();
            DoktorTcTxt = new TextBox();
            ErkekRadioBtn = new RadioButton();
            KadınRadioBtn = new RadioButton();
            DoktorKayitOlBtn = new Button();
            DoktorDgmDateTimePicker = new DateTimePicker();
            DoktorUzmnTxt = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            fotografYukleBtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 300);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 342);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 386);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 442);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 3;
            label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 490);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 4;
            label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 552);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 5;
            label6.Text = "Uzmanlık Alanı:";
            // 
            // DoktorAdTxt
            // 
            DoktorAdTxt.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DoktorAdTxt.Location = new Point(175, 296);
            DoktorAdTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorAdTxt.Name = "DoktorAdTxt";
            DoktorAdTxt.Size = new Size(281, 32);
            DoktorAdTxt.TabIndex = 6;
            // 
            // DoktorSydTxt
            // 
            DoktorSydTxt.Location = new Point(175, 339);
            DoktorSydTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorSydTxt.Name = "DoktorSydTxt";
            DoktorSydTxt.Size = new Size(281, 35);
            DoktorSydTxt.TabIndex = 7;
            // 
            // DoktorTcTxt
            // 
            DoktorTcTxt.Location = new Point(175, 379);
            DoktorTcTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorTcTxt.Name = "DoktorTcTxt";
            DoktorTcTxt.Size = new Size(281, 35);
            DoktorTcTxt.TabIndex = 8;
            // 
            // ErkekRadioBtn
            // 
            ErkekRadioBtn.AutoSize = true;
            ErkekRadioBtn.Location = new Point(175, 438);
            ErkekRadioBtn.Margin = new Padding(3, 4, 3, 4);
            ErkekRadioBtn.Name = "ErkekRadioBtn";
            ErkekRadioBtn.Size = new Size(76, 32);
            ErkekRadioBtn.TabIndex = 11;
            ErkekRadioBtn.TabStop = true;
            ErkekRadioBtn.Text = "Erkek";
            ErkekRadioBtn.UseVisualStyleBackColor = true;
            // 
            // KadınRadioBtn
            // 
            KadınRadioBtn.AutoSize = true;
            KadınRadioBtn.Location = new Point(380, 434);
            KadınRadioBtn.Margin = new Padding(3, 4, 3, 4);
            KadınRadioBtn.Name = "KadınRadioBtn";
            KadınRadioBtn.Size = new Size(76, 32);
            KadınRadioBtn.TabIndex = 12;
            KadınRadioBtn.TabStop = true;
            KadınRadioBtn.Text = "Kadın";
            KadınRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DoktorKayitOlBtn
            // 
            DoktorKayitOlBtn.Location = new Point(175, 588);
            DoktorKayitOlBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorKayitOlBtn.Name = "DoktorKayitOlBtn";
            DoktorKayitOlBtn.Size = new Size(281, 87);
            DoktorKayitOlBtn.TabIndex = 13;
            DoktorKayitOlBtn.Text = "Kayıt Ol";
            DoktorKayitOlBtn.UseVisualStyleBackColor = true;
            DoktorKayitOlBtn.Click += DoktorKayitOlBtn_Click;
            // 
            // DoktorDgmDateTimePicker
            // 
            DoktorDgmDateTimePicker.Location = new Point(175, 483);
            DoktorDgmDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            DoktorDgmDateTimePicker.Name = "DoktorDgmDateTimePicker";
            DoktorDgmDateTimePicker.Size = new Size(281, 35);
            DoktorDgmDateTimePicker.TabIndex = 14;
            // 
            // DoktorUzmnTxt
            // 
            DoktorUzmnTxt.Location = new Point(175, 545);
            DoktorUzmnTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorUzmnTxt.Name = "DoktorUzmnTxt";
            DoktorUzmnTxt.Size = new Size(281, 35);
            DoktorUzmnTxt.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 136);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Snow;
            label7.Font = new Font("Yu Gothic Medium", 24F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(305, 61);
            label7.Name = "label7";
            label7.Size = new Size(409, 52);
            label7.TabIndex = 0;
            label7.Text = "Doktor Kayıt  Formu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(220, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 148);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(175, 169);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(281, 56);
            trackBar1.TabIndex = 18;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // fotografYukleBtn
            // 
            fotografYukleBtn.Location = new Point(175, 233);
            fotografYukleBtn.Margin = new Padding(3, 4, 3, 4);
            fotografYukleBtn.Name = "fotografYukleBtn";
            fotografYukleBtn.Size = new Size(281, 41);
            fotografYukleBtn.TabIndex = 19;
            fotografYukleBtn.Text = "Fotoğraf Yükle";
            fotografYukleBtn.UseVisualStyleBackColor = true;
            fotografYukleBtn.Click += fotografYukleBtn_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(fotografYukleBtn);
            panel2.Controls.Add(DoktorKayitOlBtn);
            panel2.Controls.Add(DoktorUzmnTxt);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(DoktorDgmDateTimePicker);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(DoktorAdTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(KadınRadioBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(DoktorSydTxt);
            panel2.Controls.Add(ErkekRadioBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(DoktorTcTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(217, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 687);
            panel2.TabIndex = 20;
            // 
            // DoktorKayit
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 869);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoktorKayit";
            Text = "DoktorKayit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DoktorAdTxt;
        private TextBox DoktorSydTxt;
        private TextBox DoktorTcTxt;
        private RadioButton ErkekRadioBtn;
        private RadioButton KadınRadioBtn;
        private Button DoktorKayitOlBtn;
        private DateTimePicker DoktorDgmDateTimePicker;
        private TextBox DoktorUzmnTxt;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private Button fotografYukleBtn;
        private Panel panel2;
    }
}