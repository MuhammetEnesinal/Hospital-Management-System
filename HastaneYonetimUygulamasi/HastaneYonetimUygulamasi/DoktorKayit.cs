using Npgsql;
using System.Data;



namespace HastaneYonetimUygulamasi
{
    public partial class DoktorKayit : Form
    {

        private Image originalImage;
        public DoktorKayit()
        {
            InitializeComponent();

            trackBar1.Minimum = 10;  // Minimum %10
            trackBar1.Maximum = 200; // Maksimum %200
            trackBar1.Value = 100;   // Başlangıçta %100 boyut
        }

        private void DoktorKayitOlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cinsiyet = "";

                if (DoktorAdTxt.Text == "" || DoktorSydTxt.Text == "" || DoktorTcTxt.Text == "" || DoktorUzmnTxt.Text == "" || DoktorTcTxt.Text.Length != 11 || (!ErkekRadioBtn.Checked && !KadınRadioBtn.Checked) || DoktorDgmDateTimePicker.Value > DateTime.Now || pictureBox1.Image == null || !long.TryParse(DoktorTcTxt.Text, out _) || DoktorTcTxt.Text.Length != 11)
                {
                    throw new KayitException("Kayıt yapılırken hata oluştu, lütfen tüm bilgileri doğru girdiğinizden emin olun.");
                }
                else
                {
                    if (ErkekRadioBtn.Checked)
                    {
                        cinsiyet = "Erkek";
                    }
                    else if (KadınRadioBtn.Checked)
                    {
                        cinsiyet = "Kadın";
                    }

                    byte[] fotoData;
                    using (var ms = new System.IO.MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Fotoğrafı JPEG formatında kaydet
                        fotoData = ms.ToArray(); // Fotoğrafı byte dizisine dönüştür
                    }


                    // TC kontrolü
                    string Tcquery = "SELECT tc FROM doktorkayit WHERE tc = @tc";
                    var tcParameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@tc", DoktorTcTxt.Text.Trim().ToUpper())
                    };

                    Database db = new Database();
                    DataTable result = db.ExecuteQuery(Tcquery, tcParameters);

                    if (result.Rows.Count > 0)
                    {
                        MessageBox.Show("Daha önce kayıtlı TC no bulundu...");
                        return;
                    }

                    // Yeni doktor kaydı ekleme sorgusu
                    string DoktorKayitQuery = @"
                        INSERT INTO doktorkayit 
                        (ad, soyad, tc, cinsiyet, dogumtarihi, uzmanlikalani,fotograf) 
                        VALUES 
                        (@ad, @soyad, @tc, @cinsiyet, @dogumtarihi, @uzmanlikalani,@fotograf)";

                    // Parametreleri tanımlama
                    var doktorParameters = new NpgsqlParameter[]
                                {
                        new NpgsqlParameter("@ad", DoktorAdTxt.Text.Trim().ToUpper()),
                        new NpgsqlParameter("@soyad", DoktorSydTxt.Text.Trim().ToUpper()),
                        new NpgsqlParameter("@tc", DoktorTcTxt.Text.Trim().ToUpper()),
                        new NpgsqlParameter("@cinsiyet", cinsiyet.ToUpper()),
                        new NpgsqlParameter("@dogumtarihi", DoktorDgmDateTimePicker.Value),
                        new NpgsqlParameter("@uzmanlikalani", DoktorUzmnTxt.Text.Trim().ToUpper()),
                        new NpgsqlParameter("@fotograf", fotoData)
                    };

                    // Sorguyu çalıştır
                    int rowsAffected = db.ExecuteNonQuery(DoktorKayitQuery, doktorParameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Başarıyla kayıt olundu...");
                        this.Close();
                    }
                    else
                    {
                        throw new KayitException("Kayit olunurken hata oluştu lütfen tüm alanları eksiksiz doldurduğunuzdan emin olunuz..");
                    }
                }
            }catch(KayitException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }



        }

        private void fotografYukleBtn_Click_1(object sender, EventArgs e)
        {
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
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null) 
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

