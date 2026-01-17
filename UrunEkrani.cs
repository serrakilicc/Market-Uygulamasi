using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mağaza  
{
   //interface
    public interface IUrun
    {
        string Ad { get; set; }
        double Fiyat { get; set; }
    }

    public partial class UrunEkrani : Form
    {
        
        public static List<string> Sepetim = new List<string>();
        public static double ToplamTutar = 0;
       
        public static double IndirimTutari = 0;

        public UrunEkrani()
        {
            InitializeComponent();
        }

       //polimorfizm
        public void SepeteEkle(string urunAd, double fiyat)
        {
            ToplamTutar += fiyat;
            Sepetim.Add(urunAd + " - " + fiyat + " TL");
            GuncelleArayuz();
        }


        public void SepeteEkle(string urunAd, double fiyat, int adet)
        {
            double araToplam = fiyat * adet;
            ToplamTutar += araToplam;
            Sepetim.Add(urunAd + " (x" + adet + ") - " + araToplam + " TL");
            GuncelleArayuz();
        }

       
        private void GuncelleArayuz()
        {
           
            lstSepet.Items.Clear();
            foreach (string urun in Sepetim)
            {
                lstSepet.Items.Add(urun);
            }
            
            lblToplam.Text = "TOPLAM: " + ToplamTutar + " TL";
        }

        //Buton Tıklaması
        #region Urunler

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Su", 5);
        }

        private void btnEkmekEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Ekmek", 15);
        }

        private void btnPeynirEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Peynir", 145);
        }

        private void btnTuzEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Tuz", 50);
        }

        private void btnYogurtEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Yogurt", 100);
        }

        private void btnSutEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Süt", 40);
        }

        private void btnArmutEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Armut", 90);
        }

        private void btnElmaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Elma", 95);
        }

        private void btnDondurmaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Dondurma", 120);
        }

        private void btnGofretEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Gofret", 20);
        }

        private void btnKiymaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Kıyma", 350);
        }

        private void btnMakarnaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Makarna", 30);
        }

        private void btnMeyvesEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Meyve Suyu", 20);
        }

        private void btnNuggetEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Nugget", 60);
        }

        private void btnSabunEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Sabun", 95);
        }

        private void btnTursuEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Turşu", 60);
        }

        private void btnYemisEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Kuruyemiş", 110);
        }

        private void btnYumurtaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Yumurta", 210);
        }

        private void btnKulakEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Kulak Çubuğu", 30);
        }

        private void btnSodaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Soda", 15);
        }

        private void btnMamaEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Kedi Maması", 30);
        }

        private void btnCipsEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("Cips", 35);
        }
        private void btnPosetEkle_Click(object sender, EventArgs e)
        {
            SepetGuncelle("EKSTRA POŞET", 5);
        }
        #endregion Urunler
        private void SepetGuncelle(string urunAdi, double fiyat)
        {
            int index = Sepetim.FindIndex(x => x.StartsWith(urunAdi));

            if (index != -1)
            {
                string mevcutSatir = Sepetim[index];
                int adet = 1;

                if (mevcutSatir.Contains("x"))
                {
                    
                    string[] parcalar = mevcutSatir.Split('x');
                    string adetMetni = parcalar[parcalar.Length - 1].Trim();

                    if (int.TryParse(adetMetni, out int mevcutAdet))
                    {
                        adet = mevcutAdet + 1;
                    }
                }
                else
                {
                    adet = 2;
                }

               
                Sepetim[index] = urunAdi + " - " + fiyat + " TL x" + adet;
            }
            else
            {
                
                Sepetim.Add(urunAdi + " - " + fiyat + " TL");
            }

          
            ToplamTutar += fiyat;

            
            lstSepet.Items.Clear(); 
            foreach (string urun in Sepetim)
            {
                lstSepet.Items.Add(urun); 
            }

           
            lblToplam.Text = "Toplam: " + ToplamTutar.ToString("N2") + " TL";
        }
        
        private void UrunEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            if (Sepetim.Count == 0)
            {
                MessageBox.Show("Sepetiniz zaten boş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            DialogResult onay = MessageBox.Show("Sepetteki tüm ürünler silinecek. Emin misiniz?",
                "Sepeti Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                
                Sepetim.Clear();
                ToplamTutar = 0;

                
                GuncelleArayuz();

                MessageBox.Show("Sepetiniz başarıyla temizlendi.");
            }
        }

       
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (ToplamTutar <= 0 || Sepetim.Count == 0)
            {
                
                MessageBox.Show("Sepetiniz şu an boş! Lütfen önce ürün ekleyiniz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

             
                return;
            }

           
            KuponEkrani kuponForm = new KuponEkrani();
            kuponForm.Show();
            this.Hide();
        }

        private void lstSepet_DoubleClick(object sender, EventArgs e)
        {
           
            if (lstSepet.SelectedItem != null)
            {
                string secilenMetin = lstSepet.SelectedItem.ToString();
                UrunuEksiltVeyaSil(secilenMetin);
            }
        }
        private void UrunuEksiltVeyaSil(string urunSatiri)
        {
            
            try
            {
                string[] parcalar = urunSatiri.Split('-');
                string fiyatKismi = parcalar[1].Split('T')[0].Trim();
                double birimFiyat = double.Parse(fiyatKismi);

               
                int index = Sepetim.FindIndex(x => x == urunSatiri);

               
                if (urunSatiri.Contains("x"))
                {
                    string[] adetParcalari = urunSatiri.Split('x');
                    int mevcutAdet = int.Parse(adetParcalari[adetParcalari.Length - 1].Trim());

                    if (mevcutAdet > 1)
                    {
                       
                        int yeniAdet = mevcutAdet - 1;
                        string urunAdiVeFiyat = urunSatiri.Split('x')[0];
                        Sepetim[index] = urunAdiVeFiyat + "x" + yeniAdet;
                    }
                    else
                    {
                        
                        Sepetim.RemoveAt(index);
                    }
                }
                else
                {
                   
                    Sepetim.RemoveAt(index);
                }

                
                ToplamTutar -= birimFiyat;
                SepetListesiniGuncelle();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün silinirken bir hata oluştu.");
            }
        }

        
        private void SepetListesiniGuncelle()
        {
            lstSepet.Items.Clear();
            foreach (string urun in Sepetim)
            {
                lstSepet.Items.Add(urun);
            }
            lblToplam.Text = "Toplam: " + ToplamTutar.ToString("N2") + " TL";
        }

    }
}