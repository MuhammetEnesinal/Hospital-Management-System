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

   
    public partial class YoneticiBilgiSistemi : Form
    {
        public void doktorKaydiGoruntule() {
            string DoktorGosterQuery = @"
                        SELECT 
                        doktorID, 
                        ad AS DoktorAd, 
                        soyad AS DoktorSoyad, 
                        tc As DoktorTc,
                        cinsiyet As DoktorCinsiyet,
                        dogumTarihi As DoktorDogumTarih,
                        uzmanlikAlani 
                        FROM doktorKayit";

            try
            {
             
                Database db = new Database();

                // Parametre olmadığı için boş bir parametre listesi gönder
                dataGridView1.DataSource = db.ExecuteQuery(DoktorGosterQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }

        }
        public void HastaKaydiGoruntule()
        {
            string HastaGosterQuery = @"
                    SELECT 
                    hastaID, 
                    ad AS HastaAd, 
                    soyad AS HastaSoyad, 
                    tc As HastaTc,
                    cinsiyet As HastaCinsiyet,
                    dogumTarihi As HastaDogumTarihi
                    FROM hastaKayit";

            try
            {
              
                Database db = new Database();

                // Parametre olmadığı için boş bir parametre listesi gönder
                dataGridView1.DataSource = db.ExecuteQuery(HastaGosterQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }
        }
        private void TextBoxBoşalt()
        {
            KayıtSilIDTxt.Text = "";
            DoktorIDTxt.Text = "";
            DoktorAdTxt.Text = "";
            DoktorSydTxt.Text = "";
            DoktorTcTxt.Text = "";
            DoktorCnsytTxt.Text = "";
            DoktorUzmnTxt.Text = "";
            DoktorDogumDateTimePicker.Value = DateTime.Now;
            RandevuIDTxt.Text = "";
            RandevuHstIDTxt.Text = "";
            RandevuDktrIDTxt.Text = "";
            RandevuDktrAdTxt.Text = "";
            RandevuDktrSydTxt.Text = "";
            RandevuHstAdTxt.Text = "";
            RandevuHstSydTxt.Text = "";
            RandevuHastalıkRichTxt.Text = "";
            RandevuDateTimePicker.Value = DateTime.Now;
            RandevuDurumTxt.Text = "";
            HastaIDTxt.Text = "";
            HastaAdTxt.Text = "";
            HastaSoyadTxt.Text = "";
            HastaTcTxt.Text = "";
            HastaCnsytTxt.Text = "";
            HastaDogumDateTimePicker.Value = DateTime.Now;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;









        }

        private void YapilicakIslem()
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

                    case "Doktor Kayit Göster":
                        DoktorKayitGstrBtn.Enabled = true;
                        DoktorKayitGstrBtn.BackColor = Color.White;
                        HastaKayitGstrBtn.Enabled = false;
                        HastaKayitGstrBtn.BackColor = Color.Gray;
                        DoktorKayitSilBtn.Enabled = false;
                        DoktorKayitSilBtn.BackColor = Color.Gray;
                        KayıtSilIDTxt.Enabled = false;
                        KayıtSilIDTxt.BackColor = Color.Gray;
                        RandevuKayitBtn.Enabled = false;
                        RandevuKayitBtn.BackColor = Color.Gray;
                        HastaKayitSilBtn.Enabled = false;
                        HastaKayitSilBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;


                        break;

                    case "Hasta Kayit Göster":
                        HastaKayitGstrBtn.Enabled = true;
                        HastaKayitGstrBtn.BackColor = Color.White;
                        DoktorKayitGstrBtn.Enabled = false;
                        DoktorKayitGstrBtn.BackColor = Color.Gray;
                        DoktorKayitSilBtn.Enabled = false;
                        DoktorKayitSilBtn.BackColor=Color.Gray;
                        KayıtSilIDTxt.Enabled = false;
                        KayıtSilIDTxt.BackColor = Color.Gray;
                        HastaKayitSilBtn.Enabled = false;
                        HastaKayitSilBtn.BackColor = Color.Gray;
                        RandevuKayitBtn.Enabled = false;
                        RandevuKayitBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;
                        break;

                    case "Doktor Kayit Sil":
                        HastaKayitGstrBtn.Enabled = false;
                        HastaKayitGstrBtn.BackColor = Color.Gray;
                        DoktorKayitGstrBtn.Enabled = false;
                        DoktorKayitGstrBtn.BackColor = Color.Gray;
                        DoktorKayitSilBtn.Enabled = true;
                        DoktorKayitSilBtn.BackColor = Color.White;
                        KayıtSilIDTxt.Enabled = true;
                        KayıtSilIDTxt.BackColor = Color.White;
                        HastaKayitSilBtn.Enabled = false;
                        HastaKayitSilBtn.BackColor = Color.Gray;
                        RandevuKayitBtn.Enabled = false;
                        RandevuKayitBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;

                        doktorKaydiGoruntule();






                        break;
                    case "Hasta Kayit Sil":
                        HastaKayitSilBtn.Enabled = true;
                        HastaKayitSilBtn.BackColor =Color.White;
                        KayıtSilIDTxt.Enabled = true;
                        KayıtSilIDTxt.BackColor = Color.White;
                        DoktorKayitSilBtn.Enabled = false;
                        DoktorKayitSilBtn.BackColor =Color.Gray;
                        HastaKayitGstrBtn.Enabled = false;
                        HastaKayitGstrBtn.BackColor = Color.Gray;
                        RandevuKayitBtn.Enabled = false;
                        RandevuKayitBtn.BackColor = Color.Gray;
                        DoktorKayitGstrBtn.Enabled = false;
                        DoktorKayitGstrBtn.BackColor = Color.Gray;
                        dataGridView1.Enabled = true;

                        HastaKaydiGoruntule();

                        break;
                    case "Randevu Kayit Göster":
                        DoktorKayitGstrBtn.Enabled = false;
                        DoktorKayitGstrBtn.BackColor =Color.Gray;
                        HastaKayitGstrBtn.Enabled = false;
                        HastaKayitGstrBtn.BackColor =Color.Gray;
                        DoktorKayitSilBtn.Enabled = false;
                        DoktorKayitSilBtn.BackColor = Color.Gray;
                        KayıtSilIDTxt.Enabled = false;
                        KayıtSilIDTxt.BackColor = Color.Gray;
                        RandevuKayitBtn.Enabled = true;
                        RandevuKayitBtn.BackColor = Color.White;
                        HastaKayitSilBtn.Enabled = false;
                        HastaKayitSilBtn.BackColor=Color.Gray;
                        dataGridView1.Enabled = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem.");
                        break;
                }


            }





        }



        public YoneticiBilgiSistemi()
        {
            InitializeComponent();

           
            DoktorKayitGstrBtn.BackColor = Color.Gray;   
            HastaKayitGstrBtn.BackColor = Color.Gray;   
            DoktorKayitSilBtn.BackColor = Color.Gray;         
            RandevuKayitBtn.BackColor = Color.Gray;
            HastaKayitSilBtn.BackColor = Color.Gray;
            RandevuDateTimePicker.Format = DateTimePickerFormat.Custom;
            RandevuDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            RandevuDateTimePicker.Value = RandevuDateTimePicker.Value.AddSeconds(-RandevuDateTimePicker.Value.Second);

        }

        private void HastaKayitGstrBtn_Click(object sender, EventArgs e)
        {
            HastaKaydiGoruntule();


        }

        private void RandevuKayitBtn_Click(object sender, EventArgs e)
        {
            string RandevuGosterQuery = @"
                    SELECT 
                    randevuID,
                    DoktorID,
                    hastaID, 
                    HastaAd, 
                    HastaSoyad,
                    DoktorAd, 
                    DoktorSoyad, 
                    hastalik,
                    RandevuDurumu,
                    randevuTarihi
                    FROM randevuKayit";

            try
            {
             
                Database db = new Database();

                // Parametre olmadığı için boş bir parametre listesi gönder
                dataGridView1.DataSource = db.ExecuteQuery(RandevuGosterQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hata mesajını göster
            }

        }

        private void DoktorKayitGstrBtn_Click(object sender, EventArgs e)
        {

            doktorKaydiGoruntule();
        }

        private void DoktorKayitSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (KayıtSilIDTxt.Text.Trim() == "")
                {
                    throw new KayitException("Id boş bırakılamaz lütfen giriniz");
                }



                // silme sorgusu
          

                string RandevularıSilQuery = @"
                    DELETE FROM 
                    randevuKayit
                    WHERE doktorID=@doktorID 
                    ";

                var parametersRandevu = new NpgsqlParameter[]
                 {
                new NpgsqlParameter("@doktorID", int.Parse(KayıtSilIDTxt.Text))
                 };

                Database db = new Database();
                int rowsAffected1 = db.ExecuteNonQuery(RandevularıSilQuery, parametersRandevu);


                string DoktorSilQuery = @"
                DELETE FROM 
                doktorKayit
                WHERE doktorID=@doktorID";


                // Parametreleri tanımlama
                var parametersDoktor = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@doktorID", int.Parse(KayıtSilIDTxt.Text))
                };


                int rowsAffected2 = db.ExecuteNonQuery(DoktorSilQuery, parametersDoktor);
                

                if (rowsAffected2 > 0)
                {
                    MessageBox.Show("Doktor başarıyla silindi.");

                    doktorKaydiGoruntule();

                }
                else
                {
                    throw new KayitException("Doktor kayıtı silerken hata oluştu lütfen doğru ID girdiğinizden emin olunuz");
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


        }

        private void HastaKayitSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (KayıtSilIDTxt.Text.Trim() == "")
                {
                    throw new KayitException("Id boş bırakılamaz lütfen giriniz");
                }



                string HastaRandevuSilQuery = @"
                    DELETE FROM 
                    randevuKayit
                    WHERE hastaID=@hastaID 
                  ";

                var parametersRandevuSil = new NpgsqlParameter[]
                 {
                    new NpgsqlParameter("@hastaID", int.Parse(KayıtSilIDTxt.Text))
                 };
                Database db = new Database();
                int rowsAffected1 = db.ExecuteNonQuery(HastaRandevuSilQuery, parametersRandevuSil);


                string HastaSilQuery = @"
                    DELETE FROM 
                    hastaKayit
                    WHERE hastaID=@hastaID ";  

                // Parametreleri tanımlama
                var parametersHastaSil = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@hastaID", int.Parse(KayıtSilIDTxt.Text))
                };

                int rowsAffected2 = db.ExecuteNonQuery(HastaSilQuery, parametersHastaSil);



                

                if (rowsAffected2 > 0 )
                {
                    MessageBox.Show("Hasta başarıyla silindi.");
                    HastaKaydiGoruntule();

                }
                else
                {
                    throw new KayitException("Hasta kayıtı silerken hata oluştu lütfen doğru ID girdiğinizden emin olunuz");
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem == "Doktor Kayit Göster" || comboBox1.SelectedItem == "Doktor Kayit Sil")
            {
              
                // Satır başına tıklanıp tıklanmadığını kontrol et
                if (e.RowIndex >= 0)
                {
                    // Seçilen satırdaki hücrelerden verileri al
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Verileri TextBox'lara aktar
                    DoktorIDTxt.Text = row.Cells["doktorID"].Value.ToString();
                    DoktorAdTxt.Text = row.Cells["doktorad"].Value.ToString();
                    DoktorSydTxt.Text = row.Cells["doktorsoyad"].Value.ToString();
                    DoktorTcTxt.Text = row.Cells["doktortc"].Value.ToString();
                    DoktorCnsytTxt.Text = row.Cells["doktorcinsiyet"].Value.ToString();
                    DoktorUzmnTxt.Text = row.Cells["uzmanlikalani"].Value.ToString();
                    DoktorDogumDateTimePicker.Value = Convert.ToDateTime(row.Cells["DoktorDogumTarih"].Value);

                }

                try
                {
                    // Veritabanı işlemleri
                    Database db = new Database();

                    // Doktor bilgilerini sorgulama
                    string DoktorBilgiQuery = "SELECT * FROM doktorkayit WHERE tc = @tc";

                    // Parametreleri tanımlama
                    var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("@tc",  DoktorTcTxt.Text)
                    };

                    // Sorguyu çalıştır ve sonuçları kontrol et
                    DataTable result = db.ExecuteQuery(DoktorBilgiQuery, parameters);


                    if (result.Rows.Count > 0)
                    {
                        // İlk satırı al
                        DataRow row = result.Rows[0];

                        byte[] fotoData = (byte[])row["fotograf"]; // Fotoğraf byte dizisi
                        using (MemoryStream ms = new MemoryStream(fotoData))
                        {
                            pictureBox1.Image = Image.FromStream(ms); // Fotoğrafı PictureBox'ta göster

                        }

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





            }
            if (comboBox1.SelectedItem == "Randevu Kayit Göster")
            {
               
                // Satır başına tıklanıp tıklanmadığını kontrol et 
                if (e.RowIndex >= 0)
                {
                    // Seçilen satırdaki hücrelerden verileri al
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Verileri TextBox'lara aktar
                    RandevuIDTxt.Text = row.Cells["randevuID"].Value.ToString();
                    RandevuDktrIDTxt.Text = row.Cells["doktorID"].Value.ToString();
                    RandevuHstIDTxt.Text = row.Cells["hastaID"].Value.ToString();
                    RandevuHstAdTxt.Text = row.Cells["hastaad"].Value.ToString();
                    RandevuHstSydTxt.Text = row.Cells["hastasoyad"].Value.ToString();
                    RandevuDktrAdTxt.Text = row.Cells["doktorad"].Value.ToString();
                    RandevuDktrSydTxt.Text = row.Cells["doktorsoyad"].Value.ToString();
                    RandevuDurumTxt.Text = row.Cells["randevudurumu"].Value.ToString();
                    RandevuHastalıkRichTxt.Text = row.Cells["hastalik"].Value.ToString();
                    RandevuDateTimePicker.Value = Convert.ToDateTime(row.Cells["randevutarihi"].Value);

                }

            }
            if (comboBox1.SelectedItem == "Hasta Kayit Göster" || comboBox1.SelectedItem == "Hasta Kayit Sil")
            {
                
                // Satır başına tıklanıp tıklanmadığını kontrol et 
                if (e.RowIndex >= 0)
                {
                    // Seçilen satırdaki hücrelerden verileri al
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Verileri TextBox'lara aktar
                    HastaIDTxt.Text = row.Cells["hastaID"].Value.ToString();
                    HastaAdTxt.Text = row.Cells["hastaad"].Value.ToString();
                    HastaSoyadTxt.Text = row.Cells["hastasoyad"].Value.ToString();
                    HastaTcTxt.Text = row.Cells["hastatc"].Value.ToString();
                    HastaCnsytTxt.Text = row.Cells["hastacinsiyet"].Value.ToString();
                    HastaDogumDateTimePicker.Value = Convert.ToDateTime(row.Cells["hastadogumtarihi"].Value);

                }
                try
                {



                    // Veritabanı işlemleri
                    Database db = new Database();

                    // Hasta bilgilerini sorgulama
                    string HastaBilgiQuery = "SELECT * FROM hastakayit WHERE tc = @tc";

                    // Sorgu parametresi
                    var parameters = new NpgsqlParameter[]
                    {
                 new NpgsqlParameter("@tc", HastaTcTxt.Text)
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
                            pictureBox2.Image = Image.FromStream(ms); // Fotoğrafı PictureBox'ta göster

                        }




                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }





            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            YapilicakIslem();
            CheckBox1.Checked = false;
            TextBoxBoşalt();

        }

     
      

        
    }
}
