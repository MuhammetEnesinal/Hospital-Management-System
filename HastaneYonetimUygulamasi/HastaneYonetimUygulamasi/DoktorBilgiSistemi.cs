using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HastaneYonetimUygulamasi
{
    public partial class DoktorBilgiSistemi : Form
    {
        public void randevularıGoster()
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
                    JOIN doktorKayit d ON r.doktorID = d.doktorID  
                    WHERE d.doktorID = @doktorID and ( r.randevuDurumu='BEKLEMEDE' or  r.randevuDurumu='KABUL' )";

            try
            {
                // Database sınıfını kullanarak bağlantıyı ve sorguyu yönetiyoruz
                Database db = new Database();

                // Parametreyi oluştur
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@doktorID", int.Parse(DoktorIdTxt.Text))
                };

                // Sorguyu çalıştır ve sonucu DataGridView'e ata
                dataGridView1.DataSource = db.ExecuteQuery(RadevuGosterQuery, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }

        }


        DoktorBilgiGuncelleme doktorBilgiGuncelleme;
        private void TextBoxBoşalt()
        {

            RandevuIdTxt.Text = "";
            HastaAdTxt.Text = "";
            HastaSydTxt.Text = "";
            HastaHstTxt.Text = "";
            RandevuTrhDateTimePicker.Value = DateTime.Now;
            RandevuIdTxt.Focus();


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

                    case "Randevu Görüntüle":
                        RandevuKblBtn.Enabled = false;
                        RandevuKblBtn.BackColor = Color.CornflowerBlue;
                        RandevuIptalBtn.Enabled = false;
                        RandevuIptalBtn.BackColor = Color.CornflowerBlue;
                        RandevuGrstrBtn.Enabled = true;
                        RandevuGrstrBtn.BackColor = Color.White;
                        RandevuIdTxt.BackColor = Color.Gray;
                        RandevuIdTxt.ForeColor = Color.Black;
                        RandevuIdTxt.Enabled = false;
                        KisiselBilgiGuncelleBtn.Enabled = false;
                        KisiselBilgiGuncelleBtn.BackColor = Color.CornflowerBlue;
                        break;

                    case "Randevu Kabul":
                        RandevuIdTxt.Enabled = true;
                        RandevuIdTxt.BackColor = Color.White;
                        RandevuIdTxt.ForeColor = Color.Black;
                        RandevuKblBtn.Enabled = true;
                        RandevuKblBtn.BackColor = Color.White;
                        RandevuIptalBtn.Enabled = false;
                        RandevuIptalBtn.BackColor = Color.CornflowerBlue;
                        RandevuGrstrBtn.Enabled = false;
                        RandevuGrstrBtn.BackColor = Color.CornflowerBlue;
                        KisiselBilgiGuncelleBtn.Enabled = false;
                        KisiselBilgiGuncelleBtn.BackColor = Color.CornflowerBlue;
                        break;

                    case "Randevu İptal":
                        RandevuIdTxt.Enabled = true;
                        RandevuIdTxt.BackColor = Color.White;
                        RandevuIdTxt.ForeColor = Color.Black;
                        RandevuIptalBtn.Enabled = true;
                        RandevuIptalBtn.BackColor = Color.White;
                        RandevuGrstrBtn.Enabled = false;
                        RandevuGrstrBtn.BackColor = Color.CornflowerBlue;
                        RandevuKblBtn.Enabled = false;
                        RandevuKblBtn.BackColor = Color.CornflowerBlue;
                        KisiselBilgiGuncelleBtn.Enabled =false;
                        KisiselBilgiGuncelleBtn.BackColor = Color.CornflowerBlue;

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
                        WHERE d.doktorID = @doktorID and ( r.randevuDurumu='BEKLEMEDE' )";

                        try
                        {
                      
                            Database db = new Database();

                         
                            var parameters = new NpgsqlParameter[]
                            {
                            new NpgsqlParameter("@doktorID", int.Parse(DoktorIdTxt.Text))
                            };

          
                            dataGridView1.DataSource = db.ExecuteQuery(RadevuGosterQuery, parameters);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); // Hata mesajını göster
                        }

                        break;

                    case "Kisisel Bilgileri Guncelle":
                        RandevuIdTxt.Enabled = false;
                        RandevuIdTxt.BackColor = Color.Gray;
                        RandevuIptalBtn.Enabled = false;
                        RandevuIptalBtn.BackColor = Color.CornflowerBlue;
                        RandevuGrstrBtn.Enabled = false;
                        RandevuGrstrBtn.BackColor = Color.CornflowerBlue;
                        RandevuKblBtn.Enabled = false;
                        RandevuKblBtn.BackColor = Color.CornflowerBlue;
                        KisiselBilgiGuncelleBtn.Enabled = true;
                        KisiselBilgiGuncelleBtn.BackColor = Color.White;
                       


                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem.");
                        break;
                }

            }
        }







        public DoktorBilgiSistemi()
        {
            InitializeComponent();
        }

        public DoktorBilgiSistemi(string tcNo)
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
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    // Doktor bilgilerini doldur
                    DoktorIdTxt.Text = row["doktorid"].ToString();
                    DoktorAdTxt.Text = row["ad"].ToString();
                    DoktorSydTxt.Text = row["soyad"].ToString();
                    label13.Text = row["ad"].ToString() + " " + row["soyad"].ToString();
                    DoktorTcTxt.Text = row["tc"].ToString();

                    if (row["cinsiyet"].ToString().ToUpper() == "ERKEK")
                    {
                        ErkekRadioBtn.Checked = true;
                    }
                    else
                    {
                        KadinRadioBtn.Checked = true;
                    }

                    DoktorDgmDateTimePicker.Value = Convert.ToDateTime(row["dogumtarihi"]);
                    DoktorUzmTxt.Text = row["uzmanlikalani"].ToString();
                }
                else
                {
                    throw new KayitException("Kayıt bulunamadı");
                }
            }
            catch (KayitException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            RandevuTrhDateTimePicker.Format = DateTimePickerFormat.Custom;
            RandevuTrhDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            RandevuTrhDateTimePicker.Value = RandevuTrhDateTimePicker.Value.AddSeconds(-RandevuTrhDateTimePicker.Value.Second);


        }

        private void RandevuGrstrBtn_Click(object sender, EventArgs e)
        {
            

            randevularıGoster();
        }

        private void RandevuIptalBtn_Click(object sender, EventArgs e)
        {
          
            try
            {


                // Güncelleme sorgusu
                string RandevuGuncelleQuery = @"
                    UPDATE randevukayit
                    SET 
                    randevuDurumu ='IPTAL'
                    WHERE randevuID = @randevuID AND randevuDurumu = 'BEKLEMEDE'";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@randevuID", int.Parse(RandevuIdTxt.Text))
                };

                // Database sınıfını kullanarak sorguyu çalıştır
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(RandevuGuncelleQuery, parameters);

               

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Randevu başarıyla iptal edildi.");
                    randevularıGoster();

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

        private void RandevuKblBtn_Click(object sender, EventArgs e)
        {
            try
            {


                // Güncelleme sorgusu
                string RandevuGuncelleQuery = @"
                    UPDATE randevukayit
                    SET 
                    randevuDurumu ='KABUL'
                    WHERE randevuID = @randevuID AND randevuDurumu = 'BEKLEMEDE'";

                // Parametreleri tanımlama
                var parameters= new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@randevuID", int.Parse(RandevuIdTxt.Text))
                };

                // Database sınıfını kullanarak sorguyu çalıştır
                Database db = new Database();
                int rowsAffected = db.ExecuteNonQuery(RandevuGuncelleQuery, parameters);


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Randevu başarıyla Kabul edildi.");
                    randevularıGoster();

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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            yapilicakIslem();
            radioButton1.Checked = false;
            TextBoxBoşalt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır başına tıklanıp tıklanmadığını kontrol et 
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki hücrelerden verileri al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                RandevuIdTxt.Text = row.Cells["randevuid"].Value.ToString();  
                HastaAdTxt.Text = row.Cells["hastaad"].Value.ToString();
                HastaSydTxt.Text = row.Cells["hastasoyad"].Value.ToString();
                HastaHstTxt.Text = row.Cells["hastalik"].Value.ToString();
                RandevuTrhDateTimePicker.Value = Convert.ToDateTime(row.Cells["randevutarihi"].Value); 

            }
        }

        private void KisiselBilgiGuncelleBtn_Click(object sender, EventArgs e)
        {
            if(doktorBilgiGuncelleme==null || doktorBilgiGuncelleme.IsDisposed)
            {
                doktorBilgiGuncelleme=new DoktorBilgiGuncelleme(DoktorTcTxt.Text);
                doktorBilgiGuncelleme.Show();

            }
            else
            {
                doktorBilgiGuncelleme.BringToFront();

            }

            this.Close();
        }
    }
}
