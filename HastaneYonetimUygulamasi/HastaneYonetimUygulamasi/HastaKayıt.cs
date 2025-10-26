using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HastaneYonetimUygulamasi
{
    public partial class HastaKayıt : Form
    {

        private Image originalImage;
        public HastaKayıt()
        {
            InitializeComponent();
            trackBar1.Minimum = 10;  // Minimum %10
            trackBar1.Maximum = 200; // Maksimum %200
            trackBar1.Value = 100;   // Başlangıçta %100 boyut
              
    }


        private void kayitOlbtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                string cinsiyet = "";

                // Giriş doğrulama
                if (adTxt.Text.Trim() == "" || soyadTxt.Text.Trim() == "" || tcTxt.Text.Trim() == "" || tcTxt.Text.Trim().Length != 11 || (!ErkekRadiobtn.Checked && !KadinRadioBtn.Checked) || dogumTarihiDateTimePicker.Value > DateTime.Now || pictureBox1.Image == null || !long.TryParse(tcTxt.Text, out _) || tcTxt.Text.Length != 11)
                {
                    throw new KayitException("Kayıt yapılırken hata oluştu, lütfen tüm bilgileri doğru girdiğinizden emin olun.");
                }
                else
                {
                    // Cinsiyet belirleme
                    if (ErkekRadiobtn.Checked)
                    {
                        cinsiyet = "Erkek";
                    }
                    else if (KadinRadioBtn.Checked)
                    {
                        cinsiyet = "Kadın";
                    }

                    byte[] fotoData;
                    using (var ms = new System.IO.MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Fotoğrafı JPEG formatında kaydet
                        fotoData = ms.ToArray(); // Fotoğrafı byte dizisine dönüştür
                    }
                    string Tcquery = "SELECT tc FROM hastakayit WHERE tc = @tc";
                    var tcParameters = new NpgsqlParameter[]
                    {
                     new NpgsqlParameter("@tc", tcTxt.Text.Trim().ToUpper())
                    };

                    Database db = new Database();
                    DataTable result = db.ExecuteQuery(Tcquery, tcParameters);

                    if (result.Rows.Count > 0)
                    {
                        MessageBox.Show("Daha önce kayıtlı TC no bulundu...");
                        return;
                    }

                    // Hasta kaydını eklemek için INSERT sorgusu
                    string insertQuery = @"
                    INSERT INTO hastakayit (ad, soyad, tc, cinsiyet, dogumtarihi, fotograf)
                    VALUES (@ad, @soyad, @tc, @cinsiyet, @dogumtarihi, @fotograf)";

                    var insertParameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("@ad", adTxt.Text.ToUpper().Trim()),
                    new NpgsqlParameter("@soyad", soyadTxt.Text.ToUpper().Trim()),
                    new NpgsqlParameter("@tc", tcTxt.Text.Trim()),
                    new NpgsqlParameter("@cinsiyet", cinsiyet.ToUpper()),
                    new NpgsqlParameter("@dogumtarihi", dogumTarihiDateTimePicker.Value),
                    new NpgsqlParameter("@fotograf", fotoData)
                    };

                    // Veritabanına veri ekleme
                    int rowsAffected = db.ExecuteNonQuery(insertQuery, insertParameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hasta başarıyla kaydedildi...");
                        this.Close(); 
                    }
                    else
                    {
                        throw new KayitException("Kayıt yapılırken hata oluştu. Lütfen tekrar deneyin.");
                    }

                }
            }
            catch (KayitException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösterme
                MessageBox.Show("Veri eklenirken bir hata oluştu: " + ex.Message);
            }


        }


        private void fotografYukleBtn_Click(object sender, EventArgs e)
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
