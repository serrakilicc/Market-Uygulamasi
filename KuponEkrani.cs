using System;
using System.Windows.Forms;

namespace mağaza
{
    
    public partial class KuponEkrani : Form
    {
        public KuponEkrani()
        {
            InitializeComponent();
        }
        private void btnKuponUygula_Click(object sender, EventArgs e)
        {
            string girilenKod = txtKupon.Text.Trim().ToUpper();

            if (girilenKod == "MAGAZA10")
            {
               
                double hesaplananIndirim = UrunEkrani.ToplamTutar * 0.10;

                
                Fiyat mevcutFiyat = new Fiyat { Tutar = UrunEkrani.ToplamTutar };
                IndirimKuponu kuponum = new IndirimKuponu(hesaplananIndirim);

                Fiyat sonFiyat = mevcutFiyat - kuponum;

                
                UrunEkrani.ToplamTutar = sonFiyat.Tutar;
                UrunEkrani.IndirimTutari = hesaplananIndirim;
                
                MessageBox.Show("Tebrikler! 'MAGAZA10' kuponu başarıyla uygulandı.\nindirim: " + hesaplananIndirim.ToString("N2") + " TL",
                                "Kupon Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblBilgi.Text = "Kupon Uygulandı! Yeni Tutar: " + UrunEkrani.ToplamTutar.ToString("N2") + " TL";
                lblBilgi.ForeColor = System.Drawing.Color.Green;

                btnKuponUygula.Enabled = false;
                txtKupon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Geçersiz Kupon Kodu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblBilgi.Text = "Geçersiz kod!";
                lblBilgi.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            OdemeEkrani odemeForm = new OdemeEkrani();
            odemeForm.Show();
            this.Hide();
        }
    }


    public class Fiyat
    {
        //property
        public double Tutar { get; set; }
        //operatör
        public static Fiyat operator -(Fiyat f, IndirimKuponu k)
        {
            Fiyat yeniFiyat = new Fiyat();
            yeniFiyat.Tutar = f.Tutar - k.IndirimMiktari;
            return yeniFiyat;
        }
    }

    public class IndirimKuponu
    {
        public double IndirimMiktari { get; set; }
        public IndirimKuponu(double miktar)
        {
            IndirimMiktari = miktar;
        }
    }
}