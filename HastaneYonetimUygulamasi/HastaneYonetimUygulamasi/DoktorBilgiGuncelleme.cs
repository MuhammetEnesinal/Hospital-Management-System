using Npgsql;

using System.Data;



namespace HastaneYonetimUygulamasi
{
    public partial class DoktorBilgiGuncelleme : Form
    {
        private Image originalImage;

        private string DoktorId;
        DoktorBilgiSistemi DoktorBilgiSistemi;
        public DoktorBilgiGuncelleme(string tcNo)
        {
            InitializeComponent();
            try
            {
                // Veritabanı işlemleri
                Database db = new Database();

                // Doktor bilgilerini sorgulama
                string DoktorBilgiQuery = "SELECT * FROM doktorkayit WHERE tc = @tc";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                 new NpgsqlParameter("@tc", tcNo)
                };

                // Sorguyu çalıştır ve sonuçları kontrol et
                DataTable result = db.ExecuteQuery(DoktorBilgiQuery, parameters);

                if (result.Rows.Count > 0)
                {



                    DataRow row = result.Rows[0];

                    byte[] fotoData = (byte[])row["fotograf"]; // Fotoğraf byte dizisi
                    using (MemoryStream ms = new MemoryStream(fotoData))
                    {
                        pictureBox1.Image = Image.FromStream(ms); // Fotoğrafı PictureBox'ta göster

                    }

                    // Doktor bilgilerini doldur

                    DoktorAdTxt.Text = row["ad"].ToString();
                    DoktorSydTxt.Text = row["soyad"].ToString();
                    DoktorId = row["doktorid"].ToString();
                    DoktorTcTxt.Text = row["tc"].ToString();

                    if (row["cinsiyet"].ToString().ToUpper() == "ERKEK")
                    {
                        ErkekRadioBtn.Checked = true;
                    }
                    else
                    {
                        KadınRadioBtn.Checked = true;
                    }

                    DoktorDgmDateTimePicker.Value = Convert.ToDateTime(row["dogumtarihi"]);
                    DoktorUzmnTxt.Text = row["uzmanlikalani"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            trackBar1.Minimum = 10;  // Minimum %10
            trackBar1.Maximum = 200; // Maksimum %200
            trackBar1.Value = 100;   // Başlangıçta %100 boyut

        }



        private void KisiselBilgileriGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (DoktorAdTxt.Text == "" || DoktorSydTxt.Text == "" || DoktorTcTxt.Text == "" || DoktorUzmnTxt.Text == "" || DoktorTcTxt.Text.Length != 11 || (!ErkekRadioBtn.Checked && !KadınRadioBtn.Checked) || DoktorDgmDateTimePicker.Value > DateTime.Now || pictureBox1.Image == null)
                {
                    throw new KayitException("Güncelleme yapılırken hata oluştu, lütfen tüm bilgileri doğru girdiğinizden emin olun.");
                }

                string cinsiyet = "";


                if (ErkekRadioBtn.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else if (KadınRadioBtn.Checked)
                {
                    cinsiyet = "Kadın";
                }

                DateTime dogumTarihi = DoktorDgmDateTimePicker.Value;

                // Resmi byte array'e dönüştür
                byte[] fotoData = null;
                using (var ms = new System.IO.MemoryStream())
                {
                    // PictureBox'taki resmi bir Bitmap nesnesine kopyala
                    using (Bitmap bitmap = new Bitmap(pictureBox1.Image))
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // JPEG formatında kaydetme
                    }
                    fotoData = ms.ToArray(); // Fotoğrafı byte dizisine dönüştür
                }

                // Güncelleme sorgusu
                string DoktorKisielBilgiGuncelleuQuery = @"
                UPDATE doktorkayit 
                SET ad = @ad, soyad = @soyad, tc=@tc , cinsiyet = @cinsiyet, dogumtarihi = @dogumtarihi, uzmanlikalani = @uzmanlikalani, fotograf = @fotograf
                WHERE doktorID = @doktorID";

                // Parametreler
                var updateParameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@ad", DoktorAdTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@soyad", DoktorSydTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@tc",DoktorTcTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@cinsiyet", cinsiyet),
                new NpgsqlParameter("@dogumtarihi", DoktorDgmDateTimePicker.Value),
                new NpgsqlParameter("@uzmanlikalani", DoktorUzmnTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@fotograf", fotoData ),
                new NpgsqlParameter("@doktorID",int.Parse(DoktorId))

                };

                // Database sınıfı üzerinden sorguyu çalıştırma
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(DoktorKisielBilgiGuncelleuQuery, updateParameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Doktor bilgileri başarıyla güncellendi!");

                    if (DoktorBilgiSistemi == null || DoktorBilgiSistemi.IsDisposed)
                    {
                        DoktorBilgiSistemi = new DoktorBilgiSistemi(DoktorTcTxt.Text.Trim());
                        DoktorBilgiSistemi.Show();
                    }
                    else
                    {
                        DoktorBilgiSistemi.BringToFront();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu veya kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }

        private void fotografYukleBtn_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = true;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Bir Fotoğraf Seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Seçilen fotoğrafı yükle
                    originalImage = Image.FromFile(openFileDialog.FileName);

                    // Başlangıç için %100 boyutlu resmi göster
                    pictureBox1.Image = new Bitmap(originalImage);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                if (pictureBox1.Image != null) // PictureBox'ta mevcut bir resim varsa
                {
                    originalImage = pictureBox1.Image;
                    pictureBox1.Image = new Bitmap(originalImage);
                }
                else
                {
                    MessageBox.Show("Yeni bir fotoğraf seçilmedi ve mevcut bir fotoğraf yok.");
                }
            }

        }



      

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null) // Fotoğraf yüklendiyse
            {
                // TrackBar'ın değerini minimum ve maksimum arasında tut
                int boyut = trackBar1.Value;
                boyut = Math.Max(trackBar1.Minimum, Math.Min(boyut, trackBar1.Maximum));

                // Eski resmi serbest bırak
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                // Boyutlandırma işlemi
                int yeniGenislik = originalImage.Width * boyut / 100;
                int yeniYukseklik = originalImage.Height * boyut / 100;

                // Resmi yeniden boyutlandır
                Image resizedImage = new Bitmap(originalImage, new Size(yeniGenislik, yeniYukseklik));
                pictureBox1.Image = resizedImage;
            }

        }
    }
}
