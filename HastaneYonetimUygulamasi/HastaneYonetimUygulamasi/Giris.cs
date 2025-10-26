using Npgsql;

namespace HastaneYonetimUygulamasi
{

    public partial class Y�netimSistemi : Form
    {
        private HastaSistemi hastaSistemi;
        private DoktorSistemi doktorSistemi;
        private YoneticiSistemi yoneticiSistemi;

        
        public Y�netimSistemi()
        {
            InitializeComponent();

        }



        private void HastaSistemiBtn_Click(object sender, EventArgs e)
        {
            if (hastaSistemi == null || hastaSistemi.IsDisposed)
            {
                hastaSistemi = new HastaSistemi();  
                hastaSistemi.Show();
            }
            else
            {
                
                hastaSistemi.BringToFront();
            }
        }

        private void DoktorSistemiBtn_Click(object sender, EventArgs e)
        {

            if (doktorSistemi == null || doktorSistemi.IsDisposed)
            {
                doktorSistemi = new DoktorSistemi();
                doktorSistemi.Show();

            }
            else
            {
                doktorSistemi.BringToFront();
            }

        }

        private void YoneticiSistemiBtn_Click(object sender, EventArgs e)
        {
            if(yoneticiSistemi==null || yoneticiSistemi.IsDisposed)
            {
                yoneticiSistemi= new YoneticiSistemi();
                yoneticiSistemi.Show();

            }
            else
            {
                yoneticiSistemi.BringToFront();
            }
        }
    }
}
