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
    public partial class YoneticiSistemi : Form
    {
        public YoneticiSistemi()
        {
            InitializeComponent();
        }

        YoneticiBilgiSistemi YoneticiBilgiSistemi;

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            string kullanici_Adi = "enes";
            string sifre = "1234";
           
            if (kullanici_Adi == KullaniciAdTxt.Text.Trim() && sifre == SifreTxt.Text)
            {
                if (YoneticiBilgiSistemi == null || YoneticiBilgiSistemi.IsDisposed)
                {

                    YoneticiBilgiSistemi = new YoneticiBilgiSistemi();
                    YoneticiBilgiSistemi.Show();

                }
                else
                {
                    YoneticiBilgiSistemi.BringToFront();
                }
                this.Close();

            }
            else
            {
                label3.Visible = true;
                label3.Text = "Kullanıcı Adı veya Şifre yanlış";

            }
          




        }

       
    }
}
