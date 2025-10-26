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
using static System.Net.Mime.MediaTypeNames;

namespace HastaneYonetimUygulamasi
{
    public partial class HastaSistemi : Form
    {
        private HastaKayıt hastaKayit;
        private HastaBilgiSistemi hastaBilgiSistemi;
        
        public HastaSistemi()
        {
            InitializeComponent();
        }

        private void HastaGrsBtn_Click(object sender, EventArgs e)
        {



            

            try
            {
                // Giriş doğrulama

                if (HastaAdTxt.Text.Trim() == "" || HastaSydTxt.Text.Trim() == "" || HastaTcTxt.Text.Trim() == "" || HastaTcTxt.Text.Trim().Length != 11)
                {
                    throw new GirisException("Lütfen tüm alanları eksiksiz ve doğru bir şekilde doldurunuz...");
                }
                
       
                // Veritabanı işlemleri
                Database db = new Database();

                // Hasta sorgusu
                string Tcquery = @"
                SELECT ad, soyad, tc 
                FROM hastakayit 
                WHERE ad = @ad AND soyad = @soyad AND tc = @tc";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@ad", HastaAdTxt.Text.ToUpper().Trim()),
                new NpgsqlParameter("@soyad", HastaSydTxt.Text.ToUpper().Trim()),
                new NpgsqlParameter("@tc", HastaTcTxt.Text.Trim())
                };

                // Sorguyu çalıştır ve sonuçları kontrol et
                DataTable result = db.ExecuteQuery(Tcquery, parameters);

                if (result.Rows.Count > 0)
                {
                    // Hasta bilgilerini gösterme formu
                    if (hastaBilgiSistemi == null || hastaBilgiSistemi.IsDisposed)
                    {
                        hastaBilgiSistemi = new HastaBilgiSistemi(result.Rows[0]["tc"].ToString());
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
                    throw new KayitException("Hasta kaydı bulunamadı...");
                }
            }
            catch (GirisException ex)
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

        private void HastaKayitlBtn_Click(object sender, EventArgs e)
        {

            if (hastaKayit == null || hastaKayit.IsDisposed)
            {

                hastaKayit = new HastaKayıt();  // Formu yeni oluştur
                hastaKayit.Show();

            }
            else
            {
                // Eğer form zaten açıksa, göster
                hastaKayit.BringToFront();
            }
           
        }

       
    }
}
