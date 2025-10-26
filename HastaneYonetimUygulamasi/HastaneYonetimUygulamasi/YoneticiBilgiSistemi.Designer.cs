namespace HastaneYonetimUygulamasi
{
    partial class YoneticiBilgiSistemi
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
            DoktorBilgileri = new GroupBox();
            pictureBox1 = new PictureBox();
            DoktorUzmnTxt = new TextBox();
            label27 = new Label();
            DoktorCnsytTxt = new TextBox();
            DoktorDogumDateTimePicker = new DateTimePicker();
            DoktorTcTxt = new TextBox();
            DoktorSydTxt = new TextBox();
            DoktorAdTxt = new TextBox();
            DoktorIDTxt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            RandevuHastalıkRichTxt = new RichTextBox();
            label26 = new Label();
            RandevuDurumTxt = new TextBox();
            RandevuDateTimePicker = new DateTimePicker();
            RandevuHstSydTxt = new TextBox();
            RandevuHstAdTxt = new TextBox();
            RandevuDktrSydTxt = new TextBox();
            RandevuDktrAdTxt = new TextBox();
            RandevuDktrIDTxt = new TextBox();
            RandevuHstIDTxt = new TextBox();
            RandevuIDTxt = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            HastaCnsytTxt = new TextBox();
            HastaDogumDateTimePicker = new DateTimePicker();
            HastaTcTxt = new TextBox();
            HastaSoyadTxt = new TextBox();
            HastaAdTxt = new TextBox();
            HastaIDTxt = new TextBox();
            label20 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            DoktorKayitGstrBtn = new Button();
            RandevuKayitBtn = new Button();
            HastaKayitGstrBtn = new Button();
            DoktorKayitSilBtn = new Button();
            HastaKayitSilBtn = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            KayıtSilIDTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CheckBox1 = new CheckBox();
            label4 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            DoktorBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 643);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1150, 408);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DoktorBilgileri
            // 
            DoktorBilgileri.Controls.Add(pictureBox1);
            DoktorBilgileri.Controls.Add(DoktorUzmnTxt);
            DoktorBilgileri.Controls.Add(label27);
            DoktorBilgileri.Controls.Add(DoktorCnsytTxt);
            DoktorBilgileri.Controls.Add(DoktorDogumDateTimePicker);
            DoktorBilgileri.Controls.Add(DoktorTcTxt);
            DoktorBilgileri.Controls.Add(DoktorSydTxt);
            DoktorBilgileri.Controls.Add(DoktorAdTxt);
            DoktorBilgileri.Controls.Add(DoktorIDTxt);
            DoktorBilgileri.Controls.Add(label10);
            DoktorBilgileri.Controls.Add(label9);
            DoktorBilgileri.Controls.Add(label8);
            DoktorBilgileri.Controls.Add(label7);
            DoktorBilgileri.Controls.Add(label6);
            DoktorBilgileri.Controls.Add(label5);
            DoktorBilgileri.Location = new Point(970, 118);
            DoktorBilgileri.Margin = new Padding(3, 4, 3, 4);
            DoktorBilgileri.Name = "DoktorBilgileri";
            DoktorBilgileri.Padding = new Padding(3, 4, 3, 4);
            DoktorBilgileri.Size = new Size(419, 517);
            DoktorBilgileri.TabIndex = 1;
            DoktorBilgileri.TabStop = false;
            DoktorBilgileri.Text = "Doktor Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(186, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 154);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // DoktorUzmnTxt
            // 
            DoktorUzmnTxt.Enabled = false;
            DoktorUzmnTxt.Location = new Point(170, 405);
            DoktorUzmnTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorUzmnTxt.Name = "DoktorUzmnTxt";
            DoktorUzmnTxt.Size = new Size(223, 35);
            DoktorUzmnTxt.TabIndex = 13;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(1, 412);
            label27.Name = "label27";
            label27.Size = new Size(140, 28);
            label27.TabIndex = 12;
            label27.Text = "Doktor Uzmanlık:";
            // 
            // DoktorCnsytTxt
            // 
            DoktorCnsytTxt.Enabled = false;
            DoktorCnsytTxt.Location = new Point(170, 357);
            DoktorCnsytTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorCnsytTxt.Name = "DoktorCnsytTxt";
            DoktorCnsytTxt.Size = new Size(223, 35);
            DoktorCnsytTxt.TabIndex = 11;
            // 
            // DoktorDogumDateTimePicker
            // 
            DoktorDogumDateTimePicker.Enabled = false;
            DoktorDogumDateTimePicker.Location = new Point(170, 463);
            DoktorDogumDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            DoktorDogumDateTimePicker.Name = "DoktorDogumDateTimePicker";
            DoktorDogumDateTimePicker.Size = new Size(223, 35);
            DoktorDogumDateTimePicker.TabIndex = 10;
            // 
            // DoktorTcTxt
            // 
            DoktorTcTxt.Enabled = false;
            DoktorTcTxt.Location = new Point(170, 318);
            DoktorTcTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorTcTxt.Name = "DoktorTcTxt";
            DoktorTcTxt.Size = new Size(223, 35);
            DoktorTcTxt.TabIndex = 9;
            // 
            // DoktorSydTxt
            // 
            DoktorSydTxt.Enabled = false;
            DoktorSydTxt.Location = new Point(170, 270);
            DoktorSydTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorSydTxt.Name = "DoktorSydTxt";
            DoktorSydTxt.Size = new Size(223, 35);
            DoktorSydTxt.TabIndex = 8;
            // 
            // DoktorAdTxt
            // 
            DoktorAdTxt.Enabled = false;
            DoktorAdTxt.Location = new Point(170, 229);
            DoktorAdTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorAdTxt.Name = "DoktorAdTxt";
            DoktorAdTxt.Size = new Size(223, 35);
            DoktorAdTxt.TabIndex = 7;
            // 
            // DoktorIDTxt
            // 
            DoktorIDTxt.Enabled = false;
            DoktorIDTxt.Location = new Point(170, 185);
            DoktorIDTxt.Margin = new Padding(3, 4, 3, 4);
            DoktorIDTxt.Name = "DoktorIDTxt";
            DoktorIDTxt.Size = new Size(223, 35);
            DoktorIDTxt.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 468);
            label10.Name = "label10";
            label10.Size = new Size(170, 28);
            label10.TabIndex = 5;
            label10.Text = "Doktor Doğum Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 364);
            label9.Name = "label9";
            label9.Size = new Size(133, 28);
            label9.TabIndex = 4;
            label9.Text = "Doktor Cinsiyet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 318);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 3;
            label8.Text = "Doktor Tc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 277);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 2;
            label7.Text = "Doktor Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 236);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 1;
            label6.Text = "Doktor Ad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 192);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 0;
            label5.Text = "Doktor ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RandevuHastalıkRichTxt);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(RandevuDurumTxt);
            groupBox2.Controls.Add(RandevuDateTimePicker);
            groupBox2.Controls.Add(RandevuHstSydTxt);
            groupBox2.Controls.Add(RandevuHstAdTxt);
            groupBox2.Controls.Add(RandevuDktrSydTxt);
            groupBox2.Controls.Add(RandevuDktrAdTxt);
            groupBox2.Controls.Add(RandevuDktrIDTxt);
            groupBox2.Controls.Add(RandevuHstIDTxt);
            groupBox2.Controls.Add(RandevuIDTxt);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(576, 118);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(388, 517);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ranadevu Bilgileri";
            // 
            // RandevuHastalıkRichTxt
            // 
            RandevuHastalıkRichTxt.Enabled = false;
            RandevuHastalıkRichTxt.Location = new Point(124, 361);
            RandevuHastalıkRichTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuHastalıkRichTxt.Name = "RandevuHastalıkRichTxt";
            RandevuHastalıkRichTxt.Size = new Size(247, 40);
            RandevuHastalıkRichTxt.TabIndex = 22;
            RandevuHastalıkRichTxt.Text = "";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(29, 373);
            label26.Name = "label26";
            label26.Size = new Size(77, 28);
            label26.TabIndex = 21;
            label26.Text = "Hastalık:";
            // 
            // RandevuDurumTxt
            // 
            RandevuDurumTxt.Enabled = false;
            RandevuDurumTxt.Location = new Point(140, 470);
            RandevuDurumTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuDurumTxt.Name = "RandevuDurumTxt";
            RandevuDurumTxt.Size = new Size(231, 35);
            RandevuDurumTxt.TabIndex = 20;
            // 
            // RandevuDateTimePicker
            // 
            RandevuDateTimePicker.Enabled = false;
            RandevuDateTimePicker.Location = new Point(124, 425);
            RandevuDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            RandevuDateTimePicker.Name = "RandevuDateTimePicker";
            RandevuDateTimePicker.Size = new Size(247, 35);
            RandevuDateTimePicker.TabIndex = 13;
            // 
            // RandevuHstSydTxt
            // 
            RandevuHstSydTxt.Enabled = false;
            RandevuHstSydTxt.Location = new Point(124, 311);
            RandevuHstSydTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuHstSydTxt.Name = "RandevuHstSydTxt";
            RandevuHstSydTxt.Size = new Size(247, 35);
            RandevuHstSydTxt.TabIndex = 19;
            // 
            // RandevuHstAdTxt
            // 
            RandevuHstAdTxt.Enabled = false;
            RandevuHstAdTxt.Location = new Point(124, 264);
            RandevuHstAdTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuHstAdTxt.Name = "RandevuHstAdTxt";
            RandevuHstAdTxt.Size = new Size(247, 35);
            RandevuHstAdTxt.TabIndex = 18;
            // 
            // RandevuDktrSydTxt
            // 
            RandevuDktrSydTxt.Enabled = false;
            RandevuDktrSydTxt.Location = new Point(124, 221);
            RandevuDktrSydTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuDktrSydTxt.Name = "RandevuDktrSydTxt";
            RandevuDktrSydTxt.Size = new Size(247, 35);
            RandevuDktrSydTxt.TabIndex = 17;
            // 
            // RandevuDktrAdTxt
            // 
            RandevuDktrAdTxt.Enabled = false;
            RandevuDktrAdTxt.Location = new Point(123, 171);
            RandevuDktrAdTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuDktrAdTxt.Name = "RandevuDktrAdTxt";
            RandevuDktrAdTxt.Size = new Size(248, 35);
            RandevuDktrAdTxt.TabIndex = 16;
            // 
            // RandevuDktrIDTxt
            // 
            RandevuDktrIDTxt.Enabled = false;
            RandevuDktrIDTxt.Location = new Point(124, 124);
            RandevuDktrIDTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuDktrIDTxt.Name = "RandevuDktrIDTxt";
            RandevuDktrIDTxt.Size = new Size(247, 35);
            RandevuDktrIDTxt.TabIndex = 15;
            // 
            // RandevuHstIDTxt
            // 
            RandevuHstIDTxt.Enabled = false;
            RandevuHstIDTxt.Location = new Point(124, 78);
            RandevuHstIDTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuHstIDTxt.Name = "RandevuHstIDTxt";
            RandevuHstIDTxt.Size = new Size(247, 35);
            RandevuHstIDTxt.TabIndex = 14;
            // 
            // RandevuIDTxt
            // 
            RandevuIDTxt.Enabled = false;
            RandevuIDTxt.Location = new Point(124, 36);
            RandevuIDTxt.Margin = new Padding(3, 4, 3, 4);
            RandevuIDTxt.Name = "RandevuIDTxt";
            RandevuIDTxt.Size = new Size(247, 35);
            RandevuIDTxt.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(0, 473);
            label19.Name = "label19";
            label19.Size = new Size(144, 28);
            label19.TabIndex = 9;
            label19.Text = "Randevu Durumu:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1, 432);
            label18.Name = "label18";
            label18.Size = new Size(129, 28);
            label18.TabIndex = 8;
            label18.Text = "Randevu Tarihi:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 318);
            label17.Name = "label17";
            label17.Size = new Size(109, 28);
            label17.TabIndex = 7;
            label17.Text = "Hasta Soyad:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 277);
            label16.Name = "label16";
            label16.Size = new Size(82, 28);
            label16.TabIndex = 6;
            label16.Text = "Hasta Ad:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1, 228);
            label15.Name = "label15";
            label15.Size = new Size(117, 28);
            label15.TabIndex = 5;
            label15.Text = "Doktor Soyad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 178);
            label14.Name = "label14";
            label14.Size = new Size(90, 28);
            label14.TabIndex = 4;
            label14.Text = "Doktor Ad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 131);
            label13.Name = "label13";
            label13.Size = new Size(84, 28);
            label13.TabIndex = 3;
            label13.Text = "Doktor ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 85);
            label12.Name = "label12";
            label12.Size = new Size(76, 28);
            label12.TabIndex = 2;
            label12.Text = "Hasta ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 43);
            label11.Name = "label11";
            label11.Size = new Size(99, 28);
            label11.TabIndex = 1;
            label11.Text = "Randevu ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(HastaCnsytTxt);
            groupBox3.Controls.Add(HastaDogumDateTimePicker);
            groupBox3.Controls.Add(HastaTcTxt);
            groupBox3.Controls.Add(HastaSoyadTxt);
            groupBox3.Controls.Add(HastaAdTxt);
            groupBox3.Controls.Add(HastaIDTxt);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Location = new Point(239, 118);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(342, 517);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Bilgileri";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(153, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 154);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // HastaCnsytTxt
            // 
            HastaCnsytTxt.Enabled = false;
            HastaCnsytTxt.Location = new Point(147, 376);
            HastaCnsytTxt.Margin = new Padding(3, 4, 3, 4);
            HastaCnsytTxt.Name = "HastaCnsytTxt";
            HastaCnsytTxt.Size = new Size(184, 35);
            HastaCnsytTxt.TabIndex = 12;
            // 
            // HastaDogumDateTimePicker
            // 
            HastaDogumDateTimePicker.Enabled = false;
            HastaDogumDateTimePicker.Location = new Point(158, 417);
            HastaDogumDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            HastaDogumDateTimePicker.Name = "HastaDogumDateTimePicker";
            HastaDogumDateTimePicker.Size = new Size(178, 35);
            HastaDogumDateTimePicker.TabIndex = 13;
            // 
            // HastaTcTxt
            // 
            HastaTcTxt.Enabled = false;
            HastaTcTxt.Location = new Point(153, 333);
            HastaTcTxt.Margin = new Padding(3, 4, 3, 4);
            HastaTcTxt.Name = "HastaTcTxt";
            HastaTcTxt.Size = new Size(178, 35);
            HastaTcTxt.TabIndex = 16;
            // 
            // HastaSoyadTxt
            // 
            HastaSoyadTxt.Enabled = false;
            HastaSoyadTxt.Location = new Point(153, 289);
            HastaSoyadTxt.Margin = new Padding(3, 4, 3, 4);
            HastaSoyadTxt.Name = "HastaSoyadTxt";
            HastaSoyadTxt.Size = new Size(178, 35);
            HastaSoyadTxt.TabIndex = 15;
            // 
            // HastaAdTxt
            // 
            HastaAdTxt.Enabled = false;
            HastaAdTxt.Location = new Point(153, 247);
            HastaAdTxt.Margin = new Padding(3, 4, 3, 4);
            HastaAdTxt.Name = "HastaAdTxt";
            HastaAdTxt.Size = new Size(178, 35);
            HastaAdTxt.TabIndex = 14;
            // 
            // HastaIDTxt
            // 
            HastaIDTxt.Enabled = false;
            HastaIDTxt.Location = new Point(153, 208);
            HastaIDTxt.Margin = new Padding(3, 4, 3, 4);
            HastaIDTxt.Name = "HastaIDTxt";
            HastaIDTxt.Size = new Size(178, 35);
            HastaIDTxt.TabIndex = 13;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(0, 422);
            label20.Name = "label20";
            label20.Size = new Size(162, 28);
            label20.TabIndex = 7;
            label20.Text = "Hasta Doğum Tarihi:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(50, 211);
            label25.Name = "label25";
            label25.Size = new Size(76, 28);
            label25.TabIndex = 6;
            label25.Text = "Hasta ID:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(48, 373);
            label24.Name = "label24";
            label24.Size = new Size(78, 28);
            label24.TabIndex = 5;
            label24.Text = "Cinsiyet:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(47, 336);
            label23.Name = "label23";
            label23.Size = new Size(79, 28);
            label23.TabIndex = 4;
            label23.Text = "Hasta Tc:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 296);
            label22.Name = "label22";
            label22.Size = new Size(109, 28);
            label22.TabIndex = 3;
            label22.Text = "Hasta Soyad:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(44, 251);
            label21.Name = "label21";
            label21.Size = new Size(82, 28);
            label21.TabIndex = 2;
            label21.Text = "Hasta Ad:";
            // 
            // DoktorKayitGstrBtn
            // 
            DoktorKayitGstrBtn.Enabled = false;
            DoktorKayitGstrBtn.Location = new Point(3, 268);
            DoktorKayitGstrBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorKayitGstrBtn.Name = "DoktorKayitGstrBtn";
            DoktorKayitGstrBtn.Size = new Size(228, 101);
            DoktorKayitGstrBtn.TabIndex = 6;
            DoktorKayitGstrBtn.Text = "Doktor Kayıtlarını göster";
            DoktorKayitGstrBtn.UseVisualStyleBackColor = true;
            DoktorKayitGstrBtn.Click += DoktorKayitGstrBtn_Click;
            // 
            // RandevuKayitBtn
            // 
            RandevuKayitBtn.Enabled = false;
            RandevuKayitBtn.Location = new Point(3, 377);
            RandevuKayitBtn.Margin = new Padding(3, 4, 3, 4);
            RandevuKayitBtn.Name = "RandevuKayitBtn";
            RandevuKayitBtn.Size = new Size(228, 101);
            RandevuKayitBtn.TabIndex = 7;
            RandevuKayitBtn.Text = "Randevu Kayıtlarını göster";
            RandevuKayitBtn.UseVisualStyleBackColor = true;
            RandevuKayitBtn.Click += RandevuKayitBtn_Click;
            // 
            // HastaKayitGstrBtn
            // 
            HastaKayitGstrBtn.Enabled = false;
            HastaKayitGstrBtn.Location = new Point(5, 161);
            HastaKayitGstrBtn.Margin = new Padding(3, 4, 3, 4);
            HastaKayitGstrBtn.Name = "HastaKayitGstrBtn";
            HastaKayitGstrBtn.Size = new Size(228, 101);
            HastaKayitGstrBtn.TabIndex = 8;
            HastaKayitGstrBtn.Text = "Hasta Kayıtlarını Göster";
            HastaKayitGstrBtn.UseVisualStyleBackColor = true;
            HastaKayitGstrBtn.Click += HastaKayitGstrBtn_Click;
            // 
            // DoktorKayitSilBtn
            // 
            DoktorKayitSilBtn.Enabled = false;
            DoktorKayitSilBtn.Location = new Point(3, 486);
            DoktorKayitSilBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorKayitSilBtn.Name = "DoktorKayitSilBtn";
            DoktorKayitSilBtn.Size = new Size(228, 101);
            DoktorKayitSilBtn.TabIndex = 9;
            DoktorKayitSilBtn.Text = "Doktor Kaydı Sil";
            DoktorKayitSilBtn.UseVisualStyleBackColor = true;
            DoktorKayitSilBtn.Click += DoktorKayitSilBtn_Click;
            // 
            // HastaKayitSilBtn
            // 
            HastaKayitSilBtn.Enabled = false;
            HastaKayitSilBtn.Location = new Point(5, 595);
            HastaKayitSilBtn.Margin = new Padding(3, 4, 3, 4);
            HastaKayitSilBtn.Name = "HastaKayitSilBtn";
            HastaKayitSilBtn.Size = new Size(228, 101);
            HastaKayitSilBtn.TabIndex = 10;
            HastaKayitSilBtn.Text = "Hasta Kaydı Sil";
            HastaKayitSilBtn.UseVisualStyleBackColor = true;
            HastaKayitSilBtn.Click += HastaKayitSilBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hasta Kayit Göster", "Hasta Kayit Sil", "Doktor Kayit Göster", "Doktor Kayit Sil", "Randevu Kayit Göster" });
            comboBox1.Location = new Point(10, 76);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 36);
            comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(KayıtSilIDTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1395, 136);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(358, 238);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Sil";
            // 
            // KayıtSilIDTxt
            // 
            KayıtSilIDTxt.Enabled = false;
            KayıtSilIDTxt.Location = new Point(108, 85);
            KayıtSilIDTxt.Margin = new Padding(3, 4, 3, 4);
            KayıtSilIDTxt.Name = "KayıtSilIDTxt";
            KayıtSilIDTxt.Size = new Size(140, 35);
            KayıtSilIDTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(29, 28);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 34);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 14;
            label3.Text = "Yapılacak işlemi seçiniz :";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(129, 121);
            CheckBox1.Margin = new Padding(3, 4, 3, 4);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(86, 32);
            CheckBox1.TabIndex = 11;
            CheckBox1.Text = "Onayla";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 121);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 15;
            label4.Text = "Onayla:";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(HastaKayitGstrBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(RandevuKayitBtn);
            panel1.Controls.Add(DoktorKayitSilBtn);
            panel1.Controls.Add(HastaKayitSilBtn);
            panel1.Controls.Add(CheckBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(DoktorKayitGstrBtn);
            panel1.Location = new Point(2, 110);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 941);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(2, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1761, 109);
            panel2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(777, 17);
            label1.Name = "label1";
            label1.Size = new Size(445, 72);
            label1.TabIndex = 19;
            label1.Text = "Yönetim Bilgi Sistemi";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(142, 42);
            label.Name = "label";
            label.Size = new Size(72, 28);
            label.TabIndex = 18;
            label.Text = "Yönetici";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images_5_;
            pictureBox3.Location = new Point(11, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // YoneticiBilgiSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1765, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(DoktorBilgileri);
            Controls.Add(groupBox2);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YoneticiBilgiSistemi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            DoktorBilgileri.ResumeLayout(false);
            DoktorBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox DoktorBilgileri;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button DoktorKayitGstrBtn;
        private Button RandevuKayitBtn;
        private Button HastaKayitGstrBtn;
        private Button DoktorKayitSilBtn;
        private Button HastaKayitSilBtn;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox KayıtSilIDTxt;
        private Label label2;
        private Label label3;
        private CheckBox CheckBox1;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker DoktorDogumDateTimePicker;
        private TextBox DoktorTcTxt;
        private TextBox DoktorSydTxt;
        private TextBox DoktorAdTxt;
        private TextBox DoktorIDTxt;
        private TextBox RandevuDurumTxt;
        private DateTimePicker RandevuDateTimePicker;
        private TextBox RandevuHstSydTxt;
        private TextBox RandevuHstAdTxt;
        private TextBox RandevuDktrSydTxt;
        private TextBox RandevuDktrAdTxt;
        private TextBox RandevuDktrIDTxt;
        private TextBox RandevuHstIDTxt;
        private TextBox RandevuIDTxt;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private DateTimePicker HastaDogumDateTimePicker;
        private TextBox HastaTcTxt;
        private TextBox HastaSoyadTxt;
        private TextBox HastaAdTxt;
        private TextBox HastaIDTxt;
        private Label label20;
        private RichTextBox RandevuHastalıkRichTxt;
        private Label label26;
        private TextBox DoktorCnsytTxt;
        private TextBox HastaCnsytTxt;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private TextBox DoktorUzmnTxt;
        private Label label27;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label;
        private PictureBox pictureBox3;
        private Label label1;
    }
}