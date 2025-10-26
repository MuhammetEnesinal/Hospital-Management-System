namespace HastaneYonetimUygulamasi
{
    partial class HastaKayıt
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
            label4 = new Label();
            adTxt = new TextBox();
            soyadTxt = new TextBox();
            dogumTarihiDateTimePicker = new DateTimePicker();
            kayitOlbtn = new Button();
            label5 = new Label();
            ErkekRadiobtn = new RadioButton();
            KadinRadioBtn = new RadioButton();
            tcTxt = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            fotografYukleBtn = new Button();
            trackBar1 = new TrackBar();
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
            label1.Location = new Point(110, 271);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 320);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 374);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 454);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 3;
            label4.Text = "Dogum Tarihi:";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(190, 264);
            adTxt.Margin = new Padding(2, 5, 2, 5);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(281, 35);
            adTxt.TabIndex = 4;
            // 
            // soyadTxt
            // 
            soyadTxt.Location = new Point(190, 313);
            soyadTxt.Margin = new Padding(2, 5, 2, 5);
            soyadTxt.Name = "soyadTxt";
            soyadTxt.Size = new Size(281, 35);
            soyadTxt.TabIndex = 5;
            // 
            // dogumTarihiDateTimePicker
            // 
            dogumTarihiDateTimePicker.Location = new Point(190, 447);
            dogumTarihiDateTimePicker.Margin = new Padding(2, 5, 2, 5);
            dogumTarihiDateTimePicker.Name = "dogumTarihiDateTimePicker";
            dogumTarihiDateTimePicker.Size = new Size(281, 35);
            dogumTarihiDateTimePicker.TabIndex = 7;
            // 
            // kayitOlbtn
            // 
            kayitOlbtn.Location = new Point(190, 518);
            kayitOlbtn.Margin = new Padding(2, 5, 2, 5);
            kayitOlbtn.Name = "kayitOlbtn";
            kayitOlbtn.Size = new Size(281, 61);
            kayitOlbtn.TabIndex = 8;
            kayitOlbtn.Text = "Kayıt Ol";
            kayitOlbtn.UseVisualStyleBackColor = true;
            kayitOlbtn.Click += kayitOlbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 407);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 9;
            label5.Text = "Cinsiyet:";
            // 
            // ErkekRadiobtn
            // 
            ErkekRadiobtn.AutoSize = true;
            ErkekRadiobtn.Location = new Point(190, 403);
            ErkekRadiobtn.Margin = new Padding(2, 5, 2, 5);
            ErkekRadiobtn.Name = "ErkekRadiobtn";
            ErkekRadiobtn.Size = new Size(76, 32);
            ErkekRadiobtn.TabIndex = 10;
            ErkekRadiobtn.TabStop = true;
            ErkekRadiobtn.Text = "Erkek";
            ErkekRadiobtn.UseVisualStyleBackColor = true;
            // 
            // KadinRadioBtn
            // 
            KadinRadioBtn.AutoSize = true;
            KadinRadioBtn.Location = new Point(395, 399);
            KadinRadioBtn.Margin = new Padding(2, 5, 2, 5);
            KadinRadioBtn.Name = "KadinRadioBtn";
            KadinRadioBtn.Size = new Size(76, 32);
            KadinRadioBtn.TabIndex = 11;
            KadinRadioBtn.TabStop = true;
            KadinRadioBtn.Text = "Kadın";
            KadinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // tcTxt
            // 
            tcTxt.Location = new Point(190, 358);
            tcTxt.Margin = new Padding(2, 5, 2, 5);
            tcTxt.Name = "tcTxt";
            tcTxt.Size = new Size(281, 35);
            tcTxt.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.InactiveBorder;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 5, 2, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 130);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Yu Gothic Medium", 24F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(392, 35);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(380, 52);
            label6.TabIndex = 0;
            label6.Text = "Hasta Kayıt Formu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(190, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 130);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // fotografYukleBtn
            // 
            fotografYukleBtn.Location = new Point(190, 214);
            fotografYukleBtn.Name = "fotografYukleBtn";
            fotografYukleBtn.Size = new Size(281, 42);
            fotografYukleBtn.TabIndex = 14;
            fotografYukleBtn.Text = "Fotoğraf yükle";
            fotografYukleBtn.UseVisualStyleBackColor = true;
            fotografYukleBtn.Click += fotografYukleBtn_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(247, 152);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(174, 56);
            trackBar1.TabIndex = 15;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(fotografYukleBtn);
            panel2.Controls.Add(kayitOlbtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dogumTarihiDateTimePicker);
            panel2.Controls.Add(ErkekRadiobtn);
            panel2.Controls.Add(KadinRadioBtn);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(adTxt);
            panel2.Controls.Add(soyadTxt);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tcTxt);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(279, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 594);
            panel2.TabIndex = 16;
            // 
            // HastaKayıt
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1131, 744);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 5, 2, 5);
            Name = "HastaKayıt";
            Text = "HastaKayıt";
            TopMost = true;
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
        private TextBox adTxt;
        private TextBox soyadTxt;
        private DateTimePicker dogumTarihiDateTimePicker;
        private Button kayitOlbtn;
        private Label label5;
        private RadioButton ErkekRadiobtn;
        private RadioButton KadinRadioBtn;
        private TextBox tcTxt;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private Button fotografYukleBtn;
        private TrackBar trackBar1;
        private Panel panel2;
    }
}