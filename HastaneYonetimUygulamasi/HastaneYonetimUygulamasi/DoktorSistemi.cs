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

namespace HastaneYonetimUygulamasi
{
    public partial class DoktorSistemi : Form
    {
        DoktorKayit doktorKayit;
        DoktorBilgiSistemi doktorBilgiSistemi;
        public DoktorSistemi()
        {
            InitializeComponent();
        }

        private void DoktorKayitBtn_Click(object sender, EventArgs e)
        {
            if (doktorKayit == null || doktorKayit.IsDisposed)
            {
                doktorKayit = new DoktorKayit();
                doktorKayit.Show();


            }
            else
            {
                doktorKayit.BringToFront();
            }


        }

        private void DoktorGrsBtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Giriş doğrulama
                if (DoktorAdTxt.Text == "" || DoktorSoyadTxt.Text == "" || DoktorTctxt.Text == "" || DoktorTctxt.Text.Length != 11)
                {

                    throw new GirisException("Lütfen tüm alanları eksiksiz ve doğru bir şekilde doldurunuz..");

                }
                // Veritabanı işlemleri
                Database db = new Database();

                // Doktor sorgusu
                string Tcquery = @"
                SELECT ad, soyad, tc 
                FROM doktorkayit 
                WHERE ad = @ad AND soyad = @soyad AND tc = @tc";

                // Parametreleri tanımlama
                var parameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@ad", DoktorAdTxt.Text.ToUpper().Trim()),
                new NpgsqlParameter("@soyad", DoktorSoyadTxt.Text.ToUpper().Trim()),
                new NpgsqlParameter("@tc",DoktorTctxt.Text.Trim())
                };

                // Sorguyu çalıştır ve sonuçları kontrol et
                DataTable result = db.ExecuteQuery(Tcquery, parameters);

                if (result.Rows.Count > 0)
                {
                    // Doktor bilgilerini gösterme formu
                    if (doktorBilgiSistemi == null || doktorBilgiSistemi.IsDisposed)
                    {
                        doktorBilgiSistemi = new DoktorBilgiSistemi(result.Rows[0]["tc"].ToString());
                        doktorBilgiSistemi.Show();
                    }
                    else
                    {
                        doktorBilgiSistemi.BringToFront();
                    }
                }
                else
                {
                    throw new KayitException("Doktor kaydı bulunamadı...");
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

       
    }
}
