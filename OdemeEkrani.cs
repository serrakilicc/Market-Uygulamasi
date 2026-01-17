using System;
using System.Drawing;
using System.Windows.Forms;

namespace mağaza
{
   
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }

       
        public void BilgileriYazdir(double toplam)
        {
            lblSonTutar.Text = "Genel Toplam : " + toplam.ToString("N2") + " TL";
            lblIndirimMiktari.Text = "Kupon İndirimi : 0,00 TL";
            lblIndirimMiktari.ForeColor = Color.Gray;
        }

        // Overloading
        public void BilgileriYazdir(double toplam, double indirim)
        {
            lblSonTutar.Text = "Genel Toplam : " + toplam.ToString("N2") + " TL";
            lblIndirimMiktari.Text = "Kupon İndirimi : " + indirim.ToString("N2") + " TL";
            lblIndirimMiktari.ForeColor = Color.Green;
        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
           
            lstFis.Items.Clear();
            foreach (string urun in UrunEkrani.Sepetim)
            {
                lstFis.Items.Add(urun);
            }
            IndirimHesaplayici hesap = new IndirimHesaplayici();
            hesap.BrutTutar = UrunEkrani.ToplamTutar;

            
            double netTutar = hesap + UrunEkrani.IndirimTutari;

            if (UrunEkrani.IndirimTutari > 0)
                BilgileriYazdir(netTutar, UrunEkrani.IndirimTutari);
            else
                BilgileriYazdir(UrunEkrani.ToplamTutar);

            pnlKartBilgileri.Visible = false;
        }

        private void rbKart_CheckedChanged(object sender, EventArgs e)
        {
            pnlKartBilgileri.Visible = rbKart.Checked;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked)
            {
                pnlKartBilgileri.Visible = false;
                mtxtKartNo.Clear();
                mtxtSKT.Clear();
                txtCVV.Clear();
            }
        }

        private void btnOdemeBitir_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(rtxtAdres.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyadınızı ve Adresinizi giriniz!", "Eksik Alan");
                return;
            }

            if (!rbNakit.Checked && !rbKart.Checked)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz!", "Eksik Seçim");
                return;
            }

            if (rbKart.Checked)
            {
                if (!mtxtKartNo.MaskFull || !mtxtSKT.MaskFull || string.IsNullOrWhiteSpace(txtCVV.Text))
                {
                    MessageBox.Show("Kart bilgilerini eksiksiz giriniz!", "Hata");
                    return;
                }
            }

            
            OdemeYontemi odemeIslemi;

            if (rbKart.Checked)
            {
                odemeIslemi = new KartliOdeme();
            }
            else
            {
                odemeIslemi = new NakitOdeme();
            }

            string sonucMesaji = odemeIslemi.Ode(UrunEkrani.ToplamTutar);
            MessageBox.Show(sonucMesaji, "İşlem Başarılı");
          
            TesekkurEkrani finalForm = new TesekkurEkrani(txtAdSoyad.Text, rtxtAdres.Text);
            finalForm.Show();
            this.Hide();
        }

      
        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (txtCVV.Text.Length == 0 && e.KeyChar == '0') e.Handled = true;
        }

        private void mtxtSKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void mtxtSKT_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = mtxtSKT.Text.Replace("/", "").Trim();
            if (input.Length >= 2)
            {
                if (int.TryParse(input.Substring(0, 2), out int ay))
                {
                    if (ay > 12 || ay == 0)
                    {
                        MessageBox.Show("Geçersiz Ay!", "Hata");
                        mtxtSKT.Clear();
                        e.Cancel = true;
                    }
                }
            }
        }

        private void mtxtSKT_MouseClick(object sender, MouseEventArgs e) => mtxtSKT.SelectionStart = 0;
        private void mtxtKartNo_MouseClick(object sender, MouseEventArgs e) => mtxtKartNo.SelectionStart = 0;

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            string ham = txtAdSoyad.Text;
            string yeni = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ham.ToLower());
            if (ham != yeni) { txtAdSoyad.Text = yeni; txtAdSoyad.SelectionStart = txtAdSoyad.Text.Length; }
        }

        private void rtxtAdres_TextChanged(object sender, EventArgs e)
        {
            string ham = rtxtAdres.Text;
            string yeni = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ham.ToLower());
            if (ham != yeni) { int pos = rtxtAdres.SelectionStart; rtxtAdres.Text = yeni; rtxtAdres.SelectionStart = pos; }
        }
    }

   //polimorfizm
    public class OdemeYontemi
    {
        public virtual string Ode(double tutar)
        {
            return "İşlem tamamlandı.";
        }
    }
    //miras
    public class KartliOdeme : OdemeYontemi
    {
        public override string Ode(double tutar)
        {
            return "Siparişinizde kart bilgileri doğrulandı. Teşekkür ederiz! (Kart İşlemi)";
        }
    }

    public class NakitOdeme : OdemeYontemi
    {
        //override
        public override string Ode(double tutar)
        {
            return "Siparişiniz kapıda ödeme olarak doğrulandı. Teşekkür ederiz!";
        }
    }
    public class IndirimHesaplayici
    {
        //kapsülleme
        private double _brutTutar;
        //property
        public double BrutTutar
        {
            get { return _brutTutar; }
            set
            {
                if (value < 0) _brutTutar = 0;
                else _brutTutar = value;
            }
        }

        public static double operator +(IndirimHesaplayici h, double indirim)
        {
            return h.BrutTutar - indirim;
        }
    }
}