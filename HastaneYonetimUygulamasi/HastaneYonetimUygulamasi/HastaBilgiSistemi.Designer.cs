namespace HastaneYonetimUygulamasi
{
    partial class HastaBilgiSistemi
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            HastaIdTxt = new TextBox();
            label11 = new Label();
            KadinRadioBtn = new RadioButton();
            ErkekRadioBtn = new RadioButton();
            label5 = new Label();
            HastaDgmDateTimePicker = new DateTimePicker();
            HastaTcTxt = new TextBox();
            HastaSydTxt = new TextBox();
            HastaAdTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            RandevuDateTimePicker = new DateTimePicker();
            RandevuGroupBox = new GroupBox();
            RandevuHastalıkTxt = new RichTextBox();
            RandevuIdTxt = new TextBox();
            label13 = new Label();
            label12 = new Label();
            DoktorSoyadTxt = new TextBox();
            DoktorAdTxt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            DoktorIdTxt = new TextBox();
            label6 = new Label();
            RandevularıGstrBtn = new Button();
            RandevuGuncelleBtn = new Button();
            RandevuEkleBtn = new Button();
            RandevuSilBtn = new Button();
            DoktorlarıGstrBtn = new Button();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            checkBox1 = new CheckBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            panel1 = new Panel();
            BilgiGuncelleBtn = new Button();
            panel2 = new Panel();
            label16 = new Label();
            label17 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RandevuGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1325, 111);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 803);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(HastaIdTxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(KadinRadioBtn);
            groupBox1.Controls.Add(ErkekRadioBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(HastaDgmDateTimePicker);
            groupBox1.Controls.Add(HastaTcTxt);
            groupBox1.Controls.Add(HastaSydTxt);
            groupBox1.Controls.Add(HastaAdTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(219, 115);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(611, 799);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(197, 50);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 150);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // HastaIdTxt
            // 
            HastaIdTxt.Enabled = false;
            HastaIdTxt.Location = new Point(197, 247);
            HastaIdTxt.Margin = new Padding(3, 4, 3, 4);
            HastaIdTxt.Name = "HastaIdTxt";
            HastaIdTxt.Size = new Size(281, 35);
            HastaIdTxt.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(128, 254);
            label11.Name = "label11";
            label11.Size = new Size(29, 28);
            label11.TabIndex = 11;
            label11.Text = "ID:";
            // 
            // KadinRadioBtn
            // 
            KadinRadioBtn.AutoSize = true;
            KadinRadioBtn.Enabled = false;
            KadinRadioBtn.Location = new Point(402, 607);
            KadinRadioBtn.Margin = new Padding(3, 4, 3, 4);
            KadinRadioBtn.Name = "KadinRadioBtn";
            KadinRadioBtn.Size = new Size(76, 32);
            KadinRadioBtn.TabIndex = 10;
            KadinRadioBtn.TabStop = true;
            KadinRadioBtn.Text = "Kadın";
            KadinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ErkekRadioBtn
            // 
            ErkekRadioBtn.AutoSize = true;
            ErkekRadioBtn.Enabled = false;
            ErkekRadioBtn.Location = new Point(197, 607);
            ErkekRadioBtn.Margin = new Padding(3, 4, 3, 4);
            ErkekRadioBtn.Name = "ErkekRadioBtn";
            ErkekRadioBtn.Size = new Size(76, 32);
            ErkekRadioBtn.TabIndex = 9;
            ErkekRadioBtn.TabStop = true;
            ErkekRadioBtn.Text = "Erkek";
            ErkekRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 611);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 8;
            label5.Text = "Cinsiyet:";
            // 
            // HastaDgmDateTimePicker
            // 
            HastaDgmDateTimePicker.Enabled = false;
            HastaDgmDateTimePicker.Location = new Point(197, 665);
            HastaDgmDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            HastaDgmDateTimePicker.Name = "HastaDgmDateTimePicker";
            HastaDgmDateTimePicker.Size = new Size(281, 35);
            HastaDgmDateTimePicker.TabIndex = 7;
            // 
            // HastaTcTxt
            // 
            HastaTcTxt.Enabled = false;
            HastaTcTxt.Location = new Point(197, 532);
            HastaTcTxt.Margin = new Padding(3, 4, 3, 4);
            HastaTcTxt.Name = "HastaTcTxt";
            HastaTcTxt.Size = new Size(281, 35);
            HastaTcTxt.TabIndex = 6;
            // 
            // HastaSydTxt
            // 
            HastaSydTxt.Enabled = false;
            HastaSydTxt.Location = new Point(197, 430);
            HastaSydTxt.Margin = new Padding(3, 4, 3, 4);
            HastaSydTxt.Name = "HastaSydTxt";
            HastaSydTxt.Size = new Size(281, 35);
            HastaSydTxt.TabIndex = 5;
            // 
            // HastaAdTxt
            // 
            HastaAdTxt.Enabled = false;
            HastaAdTxt.Location = new Point(197, 341);
            HastaAdTxt.Margin = new Padding(3, 4, 3, 4);
            HastaAdTxt.Name = "HastaAdTxt";
            HastaAdTxt.Size = new Size(281, 35);
            HastaAdTxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 677);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 3;
            label4.Text = "Dogum Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 539);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 437);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 348);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 531);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 7;
            label7.Text = "Hastalık:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 616);
            label8.Name = "label8";
            label8.Size = new Size(129, 28);
            label8.TabIndex = 8;
            label8.Text = "Randevu Tarihi:";
            // 
            // RandevuDateTimePicker
            // 
            RandevuDateTimePicker.CustomFormat = "";
            RandevuDateTimePicker.Enabled = false;
            RandevuDateTimePicker.Location = new Point(146, 616);
            RandevuDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            RandevuDateTimePicker.Name = "RandevuDateTimePicker";
            RandevuDateTimePicker.Size = new Size(315, 35);
            RandevuDateTimePicker.TabIndex = 9;
            // 
            // RandevuGroupBox
            // 
            RandevuGroupBox.BackColor = SystemColors.ScrollBar;
            RandevuGroupBox.Controls.Add(RandevuHastalıkTxt);
            RandevuGroupBox.Controls.Add(RandevuIdTxt);
            RandevuGroupBox.Controls.Add(label13);
            RandevuGroupBox.Controls.Add(label12);
            RandevuGroupBox.Controls.Add(DoktorSoyadTxt);
            RandevuGroupBox.Controls.Add(DoktorAdTxt);
            RandevuGroupBox.Controls.Add(label10);
            RandevuGroupBox.Controls.Add(label9);
            RandevuGroupBox.Controls.Add(DoktorIdTxt);
            RandevuGroupBox.Controls.Add(label6);
            RandevuGroupBox.Controls.Add(label8);
            RandevuGroupBox.Controls.Add(RandevuDateTimePicker);
            RandevuGroupBox.Controls.Add(label7);
            RandevuGroupBox.Location = new Point(825, 115);
            RandevuGroupBox.Margin = new Padding(3, 4, 3, 4);
            RandevuGroupBox.Name = "RandevuGroupBox";
            RandevuGroupBox.Padding = new Padding(3, 4, 3, 4);
            RandevuGroupBox.Size = new Size(504, 799);
            RandevuGroupBox.TabIndex = 12;
            RandevuGroupBox.TabStop = false;
            RandevuGroupBox.Text = "Randevu Bilgileri";
            // 
            // RandevuHastalıkTxt
            // 
            RandevuHastalıkTxt.Location = new Point(146, 514);
            RandevuHastalıkTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuHastalıkTxt.Name = "RandevuHastalıkTxt";
            RandevuHastalıkTxt.Size = new Size(315, 73);
            RandevuHastalıkTxt.TabIndex = 20;
            RandevuHastalıkTxt.Text = "";
            // 
            // RandevuIdTxt
            // 
            RandevuIdTxt.Enabled = false;
            RandevuIdTxt.Location = new Point(146, 250);
            RandevuIdTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuIdTxt.Name = "RandevuIdTxt";
            RandevuIdTxt.Size = new Size(315, 35);
            RandevuIdTxt.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(156, 45);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 257);
            label12.Name = "label12";
            label12.Size = new Size(99, 28);
            label12.TabIndex = 17;
            label12.Text = "Randevu ID:";
            // 
            // DoktorSoyadTxt
            // 
            DoktorSoyadTxt.Enabled = false;
            DoktorSoyadTxt.Location = new Point(146, 461);
            DoktorSoyadTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorSoyadTxt.Name = "DoktorSoyadTxt";
            DoktorSoyadTxt.Size = new Size(315, 35);
            DoktorSoyadTxt.TabIndex = 16;
            // 
            // DoktorAdTxt
            // 
            DoktorAdTxt.Enabled = false;
            DoktorAdTxt.Location = new Point(146, 385);
            DoktorAdTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorAdTxt.Name = "DoktorAdTxt";
            DoktorAdTxt.Size = new Size(315, 35);
            DoktorAdTxt.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 468);
            label10.Name = "label10";
            label10.Size = new Size(122, 28);
            label10.TabIndex = 14;
            label10.Text = "Doktor Soyadı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 388);
            label9.Name = "label9";
            label9.Size = new Size(95, 28);
            label9.TabIndex = 13;
            label9.Text = "Doktor Adı:";
            // 
            // DoktorIdTxt
            // 
            DoktorIdTxt.Enabled = false;
            DoktorIdTxt.Location = new Point(146, 314);
            DoktorIdTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorIdTxt.Name = "DoktorIdTxt";
            DoktorIdTxt.Size = new Size(315, 35);
            DoktorIdTxt.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 321);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 11;
            label6.Text = "Doktor ID:";
            // 
            // RandevularıGstrBtn
            // 
            RandevularıGstrBtn.BackColor = SystemColors.ButtonShadow;
            RandevularıGstrBtn.Enabled = false;
            RandevularıGstrBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            RandevularıGstrBtn.Location = new Point(14, 137);
            RandevularıGstrBtn.Margin = new Padding(3, 4, 3, 4);
            RandevularıGstrBtn.Name = "RandevularıGstrBtn";
            RandevularıGstrBtn.Size = new Size(201, 83);
            RandevularıGstrBtn.TabIndex = 13;
            RandevularıGstrBtn.Text = "Randevu Geçmişi";
            RandevularıGstrBtn.UseVisualStyleBackColor = false;
            RandevularıGstrBtn.Click += RandevularıGstrBtn_Click;
            // 
            // RandevuGuncelleBtn
            // 
            RandevuGuncelleBtn.BackColor = SystemColors.ButtonShadow;
            RandevuGuncelleBtn.Enabled = false;
            RandevuGuncelleBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            RandevuGuncelleBtn.Location = new Point(15, 318);
            RandevuGuncelleBtn.Margin = new Padding(3, 4, 3, 4);
            RandevuGuncelleBtn.Name = "RandevuGuncelleBtn";
            RandevuGuncelleBtn.Size = new Size(202, 83);
            RandevuGuncelleBtn.TabIndex = 14;
            RandevuGuncelleBtn.Text = "Randevu Güncelle";
            RandevuGuncelleBtn.UseVisualStyleBackColor = false;
            RandevuGuncelleBtn.Click += RandevuGuncelleBtn_Click;
            // 
            // RandevuEkleBtn
            // 
            RandevuEkleBtn.BackColor = SystemColors.ButtonShadow;
            RandevuEkleBtn.Enabled = false;
            RandevuEkleBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            RandevuEkleBtn.Location = new Point(15, 225);
            RandevuEkleBtn.Margin = new Padding(3, 4, 3, 4);
            RandevuEkleBtn.Name = "RandevuEkleBtn";
            RandevuEkleBtn.Size = new Size(202, 86);
            RandevuEkleBtn.TabIndex = 15;
            RandevuEkleBtn.Text = "Randevu Oluştur";
            RandevuEkleBtn.UseVisualStyleBackColor = false;
            RandevuEkleBtn.Click += RandevuEkleBtn_Click;
            // 
            // RandevuSilBtn
            // 
            RandevuSilBtn.BackColor = SystemColors.ButtonShadow;
            RandevuSilBtn.Enabled = false;
            RandevuSilBtn.Location = new Point(14, 409);
            RandevuSilBtn.Margin = new Padding(3, 4, 3, 4);
            RandevuSilBtn.Name = "RandevuSilBtn";
            RandevuSilBtn.Size = new Size(201, 83);
            RandevuSilBtn.TabIndex = 16;
            RandevuSilBtn.Text = "Randevu Sil";
            RandevuSilBtn.UseVisualStyleBackColor = false;
            RandevuSilBtn.Click += RandevuSilBtn_Click;
            // 
            // DoktorlarıGstrBtn
            // 
            DoktorlarıGstrBtn.BackColor = SystemColors.ButtonShadow;
            DoktorlarıGstrBtn.Enabled = false;
            DoktorlarıGstrBtn.Location = new Point(14, 500);
            DoktorlarıGstrBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorlarıGstrBtn.Name = "DoktorlarıGstrBtn";
            DoktorlarıGstrBtn.Size = new Size(201, 84);
            DoktorlarıGstrBtn.TabIndex = 17;
            DoktorlarıGstrBtn.Text = "Doktorları Göster";
            DoktorlarıGstrBtn.UseVisualStyleBackColor = false;
            DoktorlarıGstrBtn.Click += DoktorlarıGstrBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Randevu Gecmisi", "Randevu Olustur", "Randevu Guncelle", "Randevu Sil", "Doktorları Goster", "Kisisel Bilgileri Guncelle" });
            comboBox1.Location = new Point(36, 54);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 36);
            comboBox1.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(14, 7);
            label14.Name = "label14";
            label14.Size = new Size(202, 28);
            label14.TabIndex = 19;
            label14.Text = "Yapılacak işlemi seçiniz :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(17, 101);
            label15.Name = "label15";
            label15.Size = new Size(122, 28);
            label15.TabIndex = 20;
            label15.Text = "İşlemi onayla: ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(145, 101);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 32);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Onay";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BilgiGuncelleBtn);
            panel1.Controls.Add(RandevularıGstrBtn);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(RandevuEkleBtn);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(RandevuGuncelleBtn);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(RandevuSilBtn);
            panel1.Controls.Add(DoktorlarıGstrBtn);
            panel1.Location = new Point(-3, 111);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 803);
            panel1.TabIndex = 22;
            // 
            // BilgiGuncelleBtn
            // 
            BilgiGuncelleBtn.BackColor = SystemColors.ButtonShadow;
            BilgiGuncelleBtn.Enabled = false;
            BilgiGuncelleBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            BilgiGuncelleBtn.Location = new Point(14, 598);
            BilgiGuncelleBtn.Margin = new Padding(3, 4, 3, 4);
            BilgiGuncelleBtn.Name = "BilgiGuncelleBtn";
            BilgiGuncelleBtn.Size = new Size(201, 82);
            BilgiGuncelleBtn.TabIndex = 22;
            BilgiGuncelleBtn.Text = "Kişiel Bilgileri Güncelle";
            BilgiGuncelleBtn.UseVisualStyleBackColor = false;
            BilgiGuncelleBtn.Click += BilgiGuncelleBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1929, 115);
            panel2.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(219, 47);
            label16.Name = "label16";
            label16.Size = new Size(83, 28);
            label16.TabIndex = 2;
            label16.Text = "Ad+soyad";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift Condensed", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(698, 0);
            label17.Name = "label17";
            label17.Size = new Size(631, 112);
            label17.TabIndex = 1;
            label17.Text = "Hasta Bilgi Sistemi";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(32, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 96);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // HastaBilgiSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1924, 934);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(RandevuGroupBox);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HastaBilgiSistemi";
            Text = "HastaBilgiSistemi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            RandevuGroupBox.ResumeLayout(false);
            RandevuGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker HastaDgmDateTimePicker;
        private TextBox HastaTcTxt;
        private TextBox HastaSydTxt;
        private TextBox HastaAdTxt;
        private RadioButton KadinRadioBtn;
        private RadioButton ErkekRadioBtn;
        private Label label5;
        private Label label7;
        private Label label8;
        private DateTimePicker RandevuDateTimePicker;
        private GroupBox RandevuGroupBox;
        private TextBox DoktorIdTxt;
        private Label label6;
        private Button RandevularıGstrBtn;
        private Button RandevuGuncelleBtn;
        private Button RandevuEkleBtn;
        private Button RandevuSilBtn;
        private Label label10;
        private Label label9;
        private TextBox DoktorSoyadTxt;
        private TextBox DoktorAdTxt;
        private Button DoktorlarıGstrBtn;
        private TextBox HastaIdTxt;
        private Label label11;
        private TextBox RandevuIdTxt;
        private Label label13;
        private Label label12;
        private ComboBox comboBox1;
        private Label label14;
        private Label label15;
        private CheckBox checkBox1;
        private RichTextBox RandevuHastalıkTxt;
        private PictureBox pictureBox1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label17;
        private Label label16;
        private Button BilgiGuncelleBtn;
    }
}