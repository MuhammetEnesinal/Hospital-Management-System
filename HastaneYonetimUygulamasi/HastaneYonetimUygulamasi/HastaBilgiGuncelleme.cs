using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneYonetimUygulamasi
{
        
    public partial class HastaBilgiGuncelleme : Form
    {
        private Image originalImage;
        private string cinsiyet;
        private string hastaID;
        HastaBilgiSistemi hastaBilgiSistemi;
        public HastaBilgiGuncelleme(string tcNo)
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

                    }

                    hastaID = row["hastaid"].ToString();
                    adTxt.Text = row["ad"].ToString();
                    soyadTxt.Text = row["soyad"].ToString();
                    tcTxt.Text = row["tc"].ToString();


                    if (row["cinsiyet"].ToString().ToUpper() == "ERKEK")
                    {
                        ErkekRadioBtn.Checked = true;
                        cinsiyet = "ERKEK";
                    }
                    else
                    {
                        KadinRadioBtn.Checked = true;
                        cinsiyet = "KADIN";
                    }

                    dogumTarihiDateTimePicker.Value = Convert.ToDateTime(row["dogumtarihi"]);
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

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (adTxt.Text.Trim() == "" || soyadTxt.Text.Trim() == "" || tcTxt.Text.Trim() == "" || tcTxt.Text.Trim().Length != 11 || (!ErkekRadioBtn.Checked && !KadinRadioBtn.Checked) || dogumTarihiDateTimePicker.Value > DateTime.Now || pictureBox1.Image == null)
                {
                    throw new KayitException("Güncelleme yapılırken hata oluştu, lütfen tüm bilgileri doğru girdiğinizden emin olun.");
                }

                // Güncelleme sorgusu
                string HastaBilgiGuncelleQuery = @"
                UPDATE hastakayit 
                SET ad = @ad, soyad = @soyad ,tc=@tc, cinsiyet = @cinsiyet, dogumtarihi = @dogumtarihi, fotograf = @fotograf 
                WHERE hastaID = @hastaID";

                byte[] fotoData;


                using (var ms = new System.IO.MemoryStream())
                {
                    
                    using (Bitmap bitmap = new Bitmap(pictureBox1.Image))
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // JPEG formatında kaydet
                    }
                    fotoData = ms.ToArray(); // Fotoğrafı byte dizisine dönüştür
                }



                // Parametreler
                var updateParameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@ad", adTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@soyad", soyadTxt.Text.Trim().ToUpper()),
                new NpgsqlParameter("@tc", tcTxt.Text.Trim()),
                new NpgsqlParameter("@cinsiyet", cinsiyet.Trim().ToUpper()),
                new NpgsqlParameter("@dogumtarihi", dogumTarihiDateTimePicker.Value),
                new NpgsqlParameter("@fotograf", fotoData), 
                new  NpgsqlParameter("@hastaID",int.Parse(hastaID))
                };

                // Database sınıfı üzerinden sorguyu çalıştırma
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(HastaBilgiGuncelleQuery, updateParameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Hasta bilgileri başarıyla güncellendi!");

                  
                    if (hastaBilgiSistemi == null || hastaBilgiSistemi.IsDisposed)
                    {
                        hastaBilgiSistemi = new HastaBilgiSistemi(tcTxt.Text.Trim());
                        hastaBilgiSistemi.Show();
                    }
                    else
                    {
                        hastaBilgiSistemi.BringToFront();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu veya kayıt bulunamadı.");
                }
            }
            catch (KayitException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "Aynı tc de kayit  bulundu lütfen tekrar giriniz..");
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
                if (pictureBox1.Image != null) 
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

        private void trackBar1_Scroll_1(object sender, EventArgs e)
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

        private void HastaBilgiGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
