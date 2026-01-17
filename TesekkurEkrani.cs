using System;
using System.Windows.Forms;

namespace mağaza
{
    
    public partial class TesekkurEkrani : Form
    {
     
        private string musteriAd = "";
        private string musteriAdres = "";

       
        public TesekkurEkrani(string ad, string adres)
        {
            InitializeComponent();
            musteriAd = ad;
            musteriAdres = adres;
        }

        private void TesekkurEkrani_Load(object sender, EventArgs e)
        {
           
            lstOzet.Items.Clear();

          
            foreach (string urun in UrunEkrani.Sepetim)
            {
                lstOzet.Items.Add("- " + urun);
            }

           
            lblOzetTutar.Text = "Ödenen Toplam: " + UrunEkrani.ToplamTutar.ToString("N2") + " TL";

           
            lblAdresBilgi.Text = $"Sayın {musteriAd}, siparişiniz {musteriAdres} adresine ulaştırılacaktır.";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz yola çıkmak üzere hazırlandı. Güle güle!");

           
            UrunEkrani.Sepetim.Clear();
            UrunEkrani.ToplamTutar = 0;
            UrunEkrani.IndirimTutari = 0; 

            Application.Exit();
        }

        private void TesekkurEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }
    }
}