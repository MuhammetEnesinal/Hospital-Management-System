using Npgsql;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;



namespace HastaneYonetimUygulamasi
{
    public partial class HastaBilgiSistemi : Form
    {

        private HastaBilgiGuncelleme hastaBilgiGuncelleme;

        public void randevuGoster()
        {
            string RadevuGosterQuery = @"
                            SELECT 
                            r.randevuID,
                            d.doktorID,
                            d.ad AS DoktorAd, 
                            d.soyad AS DoktorSoyad, 
                            h.ad AS HastaAd, 
                            h.soyad AS HastaSoyad, 
                            r.hastalik, 
                            r.randevuTarihi, 
                            r.randevuDurumu
                            FROM randevukayit r
                            JOIN hastaKayit h ON r.hastaID = h.hastaID
                            JOIN doktorKayit d ON r.doktorID = d.doktorID  WHERE r.hastaID = @hastaID and r.randevuDurumu='BEKLEMEDE'";
            try
            {


                // Parametreyi oluştur
                var parameters2 = new NpgsqlParameter[]
                {
                        new NpgsqlParameter("@hastaID", int.Parse(HastaIdTxt.Text))
                };
                Database db = new Database();
                // Sorguyu çalıştır ve sonucu DataGridView'e ata
                dataGridView1.DataSource = db.ExecuteQuery(RadevuGosterQuery, parameters2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }


        }

        private void yapilicakIslem()
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Lütfen bir seçenek seçiniz.");
            }
            else
            {
                string yapilicakIslem = comboBox1.SelectedItem.ToString();
                switch (yapilicakIslem)
                {
                    case "Randevu Olustur":
                        RandevuIdTxt.Enabled = false;
                        RandevuIdTxt.BackColor = Color.Gray;
                        DoktorIdTxt.Enabled = true;
                        DoktorIdTxt.BackColor = Color.White;
                        DoktorAdTxt.Enabled = true;
                        DoktorAdTxt.BackColor = Color.White;
                        DoktorSoyadTxt.Enabled = true;
                        DoktorSoyadTxt.BackColor = Color.White;
                        RandevuHastalıkTxt.Enabled = true;
                        RandevuHastalıkTxt.BackColor = Color.White;
                        RandevuDateTimePicker.Enabled = true;
                        RandevuDateTimePicker.BackColor=Color.White;
                        RandevuEkleBtn.Enabled = true;
                        RandevuEkleBtn.BackColor = Color.White;
                        RandevularıGstrBtn.Enabled = false;
                        RandevularıGstrBtn.BackColor = Color.Gray;
                        RandevuSilBtn.Enabled = false;
                        RandevuSilBtn.BackColor = Color.Gray;
                        DoktorlarıGstrBtn.Enabled = false;
                        DoktorlarıGstrBtn.BackColor = Color.Gray;
                        RandevuGuncelleBtn.Enabled = false;
                        RandevuGuncelleBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = false;
                        BilgiGuncelleBtn.Enabled = false;
                        BilgiGuncelleBtn.BackColor = Color.Gray;


                        string DoktorGosterQuery = @"
                        SELECT 
                        doktorID, 
                        ad AS DoktorAd, 
                        soyad AS DoktorSoyad, 
                        uzmanlikAlani 
                        FROM doktorKayit";

                        try
                        {
                            // Database sınıfını kullanarak veritabanı işlemlerini yapıyoruz
                            Database db = new Database();

                            // Parametre olmadığı için boş bir parametre listesi gönderiyoruz
                            dataGridView1.DataSource = db.ExecuteQuery(DoktorGosterQuery);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); // Hata mesajını göster
                        }


                        break;

                    case "Randevu Gecmisi":
                        RandevuIdTxt.Enabled = false;
                   
                        RandevuIdTxt.BackColor = Color.Gray;
                        DoktorIdTxt.Enabled = false;
                      
                        DoktorIdTxt.BackColor = Color.Gray;
                        DoktorAdTxt.Enabled = false;
                     
                        DoktorAdTxt.BackColor = Color.Gray;
                        DoktorSoyadTxt.Enabled = false;
           
                        DoktorSoyadTxt.BackColor = Color.Gray;
                        RandevuHastalıkTxt.Enabled = false;
                        RandevuHastalıkTxt.BackColor = Color.Gray;
                  
                        RandevuDateTimePicker.Enabled = false;
                        RandevuDateTimePicker.BackColor = Color.Gray;
                        RandevuEkleBtn.Enabled = false;
                        RandevuEkleBtn.BackColor = Color.Gray;
                        RandevularıGstrBtn.Enabled = true;
                        RandevularıGstrBtn.BackColor = Color.White;
                        RandevuSilBtn.Enabled = false;
                        RandevuSilBtn.BackColor = Color.Gray;
                        DoktorlarıGstrBtn.Enabled = false;
                        DoktorlarıGstrBtn.BackColor = Color.Gray;
                        RandevuGuncelleBtn.Enabled = false;
                        RandevuGuncelleBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;
                        BilgiGuncelleBtn.Enabled = false;
                        BilgiGuncelleBtn.BackColor = Color.Gray;

                        break;

                    case "Randevu Guncelle":
                        RandevuIdTxt.Enabled = true;
                        RandevuIdTxt.BackColor = Color.White;
                        DoktorIdTxt.Enabled = true;
                        DoktorIdTxt.BackColor = Color.White;
                        DoktorAdTxt.Enabled = true;
                        DoktorAdTxt.BackColor = Color.White;
                        DoktorSoyadTxt.Enabled = true;
                        DoktorSoyadTxt.BackColor = Color.White;
                        RandevuHastalıkTxt.Enabled = true;
                        RandevuHastalıkTxt.BackColor = Color.White;
                        RandevuDateTimePicker.Enabled = true;
                        RandevuDateTimePicker.BackColor= Color.White;
                        RandevuEkleBtn.Enabled = false;
                        RandevuEkleBtn.BackColor = Color.Gray;
                        RandevularıGstrBtn.Enabled = false;
                        RandevularıGstrBtn.BackColor = Color.Gray;
                        RandevuSilBtn.Enabled = false;
                        RandevuSilBtn.BackColor = Color.Gray;
                        DoktorlarıGstrBtn.Enabled = false;
                        DoktorlarıGstrBtn.BackColor = Color.Gray;
                        RandevuGuncelleBtn.Enabled = true;
                        RandevuGuncelleBtn.BackColor = Color.White;
                        dataGridView1.Enabled = true;
                        BilgiGuncelleBtn.Enabled = false;
                        BilgiGuncelleBtn.BackColor = Color.Gray;



                      
                        randevuGoster();

                        break;

                    case "Randevu Sil":
                        RandevuIdTxt.Enabled = true;
                        RandevuIdTxt.BackColor = Color.White;
                        DoktorIdTxt.Enabled = false;
                
                        DoktorIdTxt.BackColor = Color.Gray;
                        DoktorAdTxt.Enabled = false;
            
                        DoktorAdTxt.BackColor = Color.Gray;
                        DoktorSoyadTxt.Enabled = false;
                   
                        DoktorSoyadTxt.BackColor = Color.Gray;
                        RandevuHastalıkTxt.Enabled = false;
                  
                        RandevuHastalıkTxt.BackColor = Color.Gray;
                        RandevuDateTimePicker.Enabled = false;
                        RandevuDateTimePicker.BackColor = Color.Gray;
                        RandevuEkleBtn.Enabled = false;
                        RandevuEkleBtn.BackColor = Color.Gray;
                        RandevularıGstrBtn.Enabled = false;
                        RandevularıGstrBtn.BackColor = Color.Gray;
                        RandevuSilBtn.Enabled = true;
                        RandevuSilBtn.BackColor = Color.White;
                        DoktorlarıGstrBtn.Enabled = false;
                        DoktorlarıGstrBtn.BackColor = Color.Gray;
                        RandevuGuncelleBtn.Enabled = false;
                        RandevuGuncelleBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;
                        BilgiGuncelleBtn.Enabled = false;
                        BilgiGuncelleBtn.BackColor = Color.Gray;



                        break;

                    case "Doktorları Goster":
                        RandevuIdTxt.Enabled = false;
                        RandevuIdTxt.BackColor = Color.Gray;
                        DoktorIdTxt.Enabled = false;
                        DoktorIdTxt.BackColor = Color.Gray;
                        DoktorAdTxt.Enabled = false;
                        DoktorAdTxt.BackColor = Color.Gray;
                        DoktorSoyadTxt.Enabled = false;
                        DoktorSoyadTxt.BackColor = Color.Gray;
                        RandevuHastalıkTxt.Enabled = false;
                        RandevuHastalıkTxt.BackColor = Color.Gray;
                        RandevuDateTimePicker.Enabled = false;
                        RandevuDateTimePicker.BackColor= Color.Gray;
                        RandevuEkleBtn.Enabled = false;
                        RandevuEkleBtn.BackColor = Color.Gray;
                        RandevularıGstrBtn.Enabled = false;
                        RandevularıGstrBtn.BackColor = Color.Gray;
                        RandevuSilBtn.Enabled = false;
                        RandevuSilBtn.BackColor = Color.Gray;
                        DoktorlarıGstrBtn.Enabled = true;
                        DoktorlarıGstrBtn.BackColor = Color.White;
                        RandevuGuncelleBtn.Enabled = false;
                        RandevuGuncelleBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = false;
                        BilgiGuncelleBtn.Enabled = false;
                        BilgiGuncelleBtn.BackColor = Color.Gray;

                        break;

                    case "Kisisel Bilgileri Guncelle":
                        RandevuIdTxt.Enabled = false;
                        RandevuIdTxt.BackColor = Color.Gray;
                        DoktorIdTxt.Enabled = false;
                        DoktorIdTxt.BackColor = Color.Gray;
                        DoktorAdTxt.Enabled = false;
                        DoktorAdTxt.BackColor = Color.Gray;
                        DoktorSoyadTxt.Enabled = false;
                        DoktorSoyadTxt.BackColor = Color.Gray;
                        RandevuHastalıkTxt.Enabled = false;
                        RandevuHastalıkTxt.BackColor = Color.Gray;
                        RandevuDateTimePicker.Enabled = false;
                        RandevuDateTimePicker.BackColor = Color.Gray;
                        RandevuEkleBtn.Enabled = false;
                        RandevuEkleBtn.BackColor = Color.Gray;
                        RandevularıGstrBtn.Enabled = false;
                        RandevularıGstrBtn.BackColor = Color.Gray;
                        RandevuSilBtn.Enabled = false;
                        RandevuSilBtn.BackColor = Color.Gray;
                        DoktorlarıGstrBtn.Enabled = false;
                        DoktorlarıGstrBtn.BackColor = Color.Gray;
                        RandevuGuncelleBtn.Enabled = false;
                        RandevuGuncelleBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = false;
                        BilgiGuncelleBtn.Enabled = true;
                        BilgiGuncelleBtn.BackColor= Color.White;

                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem.");
                        break;
                }

            }
        }



        private void TextBoxBoşalt()
        {
            RandevuIdTxt.Text = "";
            DoktorIdTxt.Text = "";
            DoktorAdTxt.Text = "";
            DoktorSoyadTxt.Text = "";
            RandevuHastalıkTxt.Text = "";
            RandevuDateTimePicker.Value = DateTime.Now;
            RandevuIdTxt.Focus();


        }

        private int DoktorKontrol()
        {
            int sonuc = 0;
            using (NpgsqlConnection baglan = new NpgsqlConnection("server=localhost; port=5432; Database=HastaneYonetim; user ID=postgres; password=enes"))
            {
                baglan.Open();


                string DoktorKontrolQuery = @"
                     SELECT COUNT(*) 
                     FROM doktorkayit 
                     WHERE doktorID = @doktorID AND ad = @doktorAd AND soyad = @doktorSoyad";

                using (var cmd1 = new NpgsqlCommand(DoktorKontrolQuery, baglan))
                {
                    cmd1.Parameters.AddWithValue("@doktorID", int.Parse(DoktorIdTxt.Text.Trim().ToUpper()));
                    cmd1.Parameters.AddWithValue("@doktorAd", DoktorAdTxt.Text.Trim().ToUpper());
                    cmd1.Parameters.AddWithValue("@doktorSoyad", DoktorSoyadTxt.Text.Trim().ToUpper());

                    sonuc = Convert.ToInt32(cmd1.ExecuteScalar());



                }

            }
            return sonuc;
        }


        // Parametreli yapıcı metot
        public HastaBilgiSistemi(string tcNo)
        {
            InitializeComponent();

            try
            {



                // Veritabanı işlemleri
                Database db = new Database();

                // Hasta bilgilerini sorgulama
                string HastaBilgiQuery = "SELECT * FROM hastakayit WHERE tc = @tc";

                // Sorgu parametresi
                var parameters = new NpgsqlParameter[]
                {
                 new NpgsqlParameter("@tc", tcNo)
                };

                // Sorguyu çalıştır ve sonuçları kontrol et
                DataTable result = db.ExecuteQuery(HastaBilgiQuery, parameters);

                if (result.Rows.Count > 0)
                {
                    // İlk satırı al
                    DataRow row = result.Rows[0];

                    byte[] fotoData = (byte[])row["fotograf"]; // Fotoğraf byte dizisi
                    using (MemoryStream ms = new MemoryStream(fotoData))
                    {
                        pictureBox1.Image = Image.FromStream(ms); // Fotoğrafı PictureBox'ta göster
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    // Hasta bilgilerini doldur
                    HastaIdTxt.Text = row["hastaid"].ToString();
                    HastaAdTxt.Text = row["ad"].ToString();
                    label16.Text = row["ad"].ToString() + " " + row["soyad"].ToString();
                    HastaSydTxt.Text = row["soyad"].ToString();
                    HastaTcTxt.Text = row["tc"].ToString();


                    if (row["cinsiyet"].ToString().ToUpper() == "ERKEK")
                    {
                        ErkekRadioBtn.Checked = true;
                    }
                    else
                    {
                        KadinRadioBtn.Checked = true;
                    }

                    HastaDgmDateTimePicker.Value = Convert.ToDateTime(row["dogumtarihi"]);
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            RandevuIdTxt.BackColor = Color.Gray;
            DoktorIdTxt.BackColor = Color.Gray;
            DoktorAdTxt.BackColor = Color.Gray;
            DoktorSoyadTxt.BackColor = Color.Gray;
            RandevuHastalıkTxt.BackColor = Color.Gray;
            RandevuEkleBtn.BackColor = Color.Gray;
            RandevularıGstrBtn.BackColor = Color.Gray;
            RandevuSilBtn.BackColor = Color.Gray;
            DoktorlarıGstrBtn.BackColor = Color.Gray;
            RandevuGuncelleBtn.BackColor = Color.Gray;








            RandevuDateTimePicker.Format = DateTimePickerFormat.Custom;
            RandevuDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            RandevuDateTimePicker.Value = RandevuDateTimePicker.Value.AddSeconds(-RandevuDateTimePicker.Value.Second);

        }

        // Parametresiz yapıcı metot
        public HastaBilgiSistemi()
        {
            InitializeComponent();
        }

        private void RandevularıGstrBtn_Click(object sender, EventArgs e)
        {
            // SQL sorgusu
            string RadevuGosterQuery = @"
                    SELECT 
                    r.randevuID,
                    d.doktorID,
                    d.ad AS DoktorAd, 
                    d.soyad AS DoktorSoyad, 
                    h.ad AS HastaAd, 
                    h.soyad AS HastaSoyad, 
                    r.hastalik, 
                    r.randevuTarihi, 
                    r.randevuDurumu
                    FROM randevukayit r
                    JOIN hastaKayit h ON r.hastaID = h.hastaID
                    JOIN doktorKayit d ON r.doktorID = d.doktorID  
                    WHERE r.hastaID = @hastaID";

            try
            {
                // Database sınıfını kullanarak bağlantıyı ve sorguyu yönetiyoruz
                Database db = new Database();

                // Parametreyi oluştur
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@hastaID", int.Parse(HastaIdTxt.Text))
                };

                // Sorguyu çalıştır ve sonucu DataGridView'e ata
                dataGridView1.DataSource = db.ExecuteQuery(RadevuGosterQuery, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }
        }

        private void DoktorlarıGstrBtn_Click(object sender, EventArgs e)
        {            // SQL sorgusu
            string DoktorGosterQuery = @"
                    SELECT 
                    doktorID, 
                    ad AS DoktorAd, 
                    soyad AS DoktorSoyad, 
                    uzmanlikAlani 
                    FROM doktorKayit";

            try
            {
                // Database sınıfını kullanarak veritabanı işlemlerini yapıyoruz
                Database db = new Database();

                // Parametre olmadığı için boş bir parametre listesi gönderiyoruz
                dataGridView1.DataSource = db.ExecuteQuery(DoktorGosterQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void RandevuEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Alanların boş olup olmadığını kontrol et
                if (DoktorIdTxt.Text.Trim() == "" || DoktorAdTxt.Text.Trim() == "" ||
                    DoktorSoyadTxt.Text.Trim() == "" || RandevuHastalıkTxt.Text.Trim() == "" ||
                    RandevuDateTimePicker.Value < DateTime.Now)
                {
                    throw new RandevuException("Randevu oluşturulurken hata oluştu. Lütfen tüm alanları eksiksiz doldurun ve randevu tarihinin gelecekte olduğundan emin olun.");
                }

                // Doktor kontrolü
                int sonuc = DoktorKontrol();
                if (sonuc <= 0)
                {
                    throw new RandevuException("Sistemde kayıtlı doktor bulunamadı. Lütfen bilgileri tekrar kontrol edin.");
                }

                // Randevu ekleme SQL sorgusu
                string RandevuEkleQuery = @"
                INSERT INTO randevukayit 
                (hastaID, doktorID, doktorAd, doktorSoyad, hastaAd, hastaSoyad, hastalik, randevuTarihi, randevuDurumu) 
                VALUES 
                (@hastaID, @doktorID, @doktorAd, @doktorSoyad, @hastaAd, @hastaSoyad, @hastalik, @randevuTarihi, @randevuDurumu)";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@hastaID", int.Parse(HastaIdTxt.Text)),
                new NpgsqlParameter("@doktorID", int.Parse(DoktorIdTxt.Text)),
                new NpgsqlParameter("@doktorAd", DoktorAdTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@doktorSoyad", DoktorSoyadTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@hastaAd", HastaAdTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@hastaSoyad", HastaSydTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@hastalik", RandevuHastalıkTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@randevuTarihi", RandevuDateTimePicker.Value),
                new NpgsqlParameter("@randevuDurumu", "BEKLEMEDE")
                };

                // Database sınıfını kullanarak sorguyu çalıştır
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(RandevuEkleQuery, parameters);              

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Randevu başarıyla eklendi.");
                    randevuGoster();

                }
                else
                {
                    throw new RandevuException(" Hata Randevu oluşturulurken hata oldu. Lütfen tüm bilgilerin doğru olduğundan emin olun.");
                }
            }
            catch (RandevuException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RandevuSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (RandevuIdTxt.Text.Trim() == "")
                {
                    throw new RandevuException("Randevu Id sini lütfen giriniz");
                }



                // silme sorgusu
                string RandevuSilQuery = @"
                    DELETE FROM 
                    randevukayit
                    WHERE hastaID=@hastaID AND randevuID=@randevuID and randevuDurumu='BEKLEMEDE' ";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@hastaid", int.Parse(HastaIdTxt.Text)),
                    new NpgsqlParameter("@randevuid", int.Parse(RandevuIdTxt.Text))
                };

                // Database sınıfını kullanarak sorguyu çalıştır
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(RandevuSilQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Randevu başarıyla silindi.");
                    randevuGoster();
                }
                else
                {
                    throw new RandevuException("Lütfen tüm randevu bilgilerini eksiksiz doldurunuz. Sadece 'Beklemede' durumundaki randevular güncellenebilir.");
                }
            }
            catch (RandevuException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (KayitException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
        private void RandevuGuncelleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Randevu tarihinin geçerliliğini kontrol et
                if (RandevuIdTxt.Text.Trim() == "" || RandevuDateTimePicker.Value < DateTime.Now)
                {
                    throw new RandevuException("Randevu Id sini ve randevu tarihinin doğru olduğundan emin olunuz");
                }

                // Doktor kontrolü
                int sonuc = DoktorKontrol();
                if (sonuc <= 0)
                {
                    throw new KayitException("Sistemde kayıtlı doktor bulunamadı. Lütfen bilgileri tekrar kontrol ediniz.");
                }

                // Güncelleme sorgusu
                string RandevuGuncelleQuery = @"
                    UPDATE randevukayit
                    SET 
                    hastaID = @hastaID,
                    doktorID = @doktorID,
                    doktorAd = @doktorAd,
                    doktorSoyad = @doktorSoyad,
                    hastaAd = @hastaAd,
                    hastaSoyad = @hastaSoyad,
                    hastalik = @hastalik,
                    randevuTarihi = @randevuTarihi
                    WHERE randevuID = @randevuID AND randevuDurumu = 'BEKLEMEDE'";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@hastaID", int.Parse(HastaIdTxt.Text)),
                    new NpgsqlParameter("@doktorID", int.Parse(DoktorIdTxt.Text)),
                    new NpgsqlParameter("@doktorAd", DoktorAdTxt.Text.Trim().ToUpper()),
                    new NpgsqlParameter("@doktorSoyad", DoktorSoyadTxt.Text.Trim().ToUpper()),
                    new NpgsqlParameter("@hastaAd", HastaAdTxt.Text.Trim().ToUpper()),
                    new NpgsqlParameter("@hastaSoyad", HastaSydTxt.Text.Trim().ToUpper()),
                    new NpgsqlParameter("@hastalik", RandevuHastalıkTxt.Text.Trim().ToUpper()),
                    new NpgsqlParameter("@randevuTarihi", RandevuDateTimePicker.Value),
                    new NpgsqlParameter("@randevuID", int.Parse(RandevuIdTxt.Text))
                };

                // Database sınıfını kullanarak sorguyu çalıştır
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(RandevuGuncelleQuery, parameters);

            



                if (rowsAffected > 0 )
                {
                    MessageBox.Show("Randevu başarıyla güncellendi.");
                    randevuGoster();
                }
                else
                {
                    throw new RandevuException("Lütfen tüm randevu bilgilerini eksiksiz doldurunuz. Sadece 'Beklemede' durumundaki randevular güncellenebilir.");
                }
            }
            catch (RandevuException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (KayitException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }





        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            yapilicakIslem();
            checkBox1.Checked = false;
            TextBoxBoşalt();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır başına tıklanıp tıklanmadığını kontrol et (başlık satırı değilse)
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki hücrelerden verileri al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                RandevuIdTxt.Text = row.Cells["randevuID"].Value.ToString();  // randevuID'yi TextBox'a aktar
                DoktorIdTxt.Text = row.Cells["doktorID"].Value.ToString();    // doktorID'yi TextBox'a aktar
                DoktorAdTxt.Text = row.Cells["DoktorAd"].Value.ToString();    // DoktorAd'ı TextBox'a aktar
                DoktorSoyadTxt.Text = row.Cells["DoktorSoyad"].Value.ToString(); //DoktorSoyad'ı TextBox'a aktar
                RandevuHastalıkTxt.Text = row.Cells["hastalik"].Value.ToString(); // hastalık bilgisini TextBox'a aktar
                RandevuDateTimePicker.Value = Convert.ToDateTime(row.Cells["randevuTarihi"].Value); // Randevu tarihini DateTimePicker'a aktar

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BilgiGuncelleBtn_Click(object sender, EventArgs e)
        {

            if(hastaBilgiGuncelleme==null || hastaBilgiGuncelleme.IsDisposed)
            {
              hastaBilgiGuncelleme=new HastaBilgiGuncelleme(HastaTcTxt.Text.Trim().ToUpper());
                hastaBilgiGuncelleme.Show();

            }
            else
            {
                hastaBilgiGuncelleme.BringToFront();
            }
            this.Close();


        }
    }



}
