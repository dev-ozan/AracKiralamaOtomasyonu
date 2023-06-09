using AracKiralamaOtomasyonu.Veri.Concrets;
using System.Runtime.Intrinsics;

namespace AracKiralamaOtomasyonu
{
    public partial class Form1 : Form
    {
        public VeriTutulanKisim v1 = new VeriTutulanKisim();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici k1 = new Kullanici(txtKullaniciAdi.Text, txtSoyad.Text, txtMail.Text, txtSifre.Text);
            v1.KullaniciListesi.Add(k1);
            MessageBox.Show("Kullanıcı başarıyla kaydedilmiştir.");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool girisBasarili = false;

            foreach (Kullanici item in v1.KullaniciListesi)
            {
                if (txtGirisKullaniciAdi.Text.Contains(item.Ad) && txtGirisSoyad.Text.Contains(item.Soyad) && btnGirisSifre.Text.Contains(item.Sifre) && btnGirisSifre.Text == item.Sifre)
                {
                    girisBasarili = true;
                    break; // Doğru kullanıcıyı bulduğumuzda döngüyü sonlandırabiliriz.
                }
            }

            if (girisBasarili)
            {
                MessageBox.Show("Başarıyla Giriş yaptınız.");

                new AracEklemeFormu(v1).ShowDialog();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol ediniz.");
            }





        }
    }
}