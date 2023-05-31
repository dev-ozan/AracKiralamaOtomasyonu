using AracKiralamaOtomasyonu.Veri.Concrets;
using AracKiralamaOtomasyonu.Veri.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{

    public partial class AracEklemeFormu : Form
    {
        AracDurumu durum;

        VeriTutulanKisim _vb;
        public AracEklemeFormu(VeriTutulanKisim vb)
        {
            _vb = vb;
            InitializeComponent();

            cmbAracDurumu.Items.AddRange(Enum.GetNames(typeof(AracDurumu)));


        }




        private void button1_Click(object sender, EventArgs e)
        {
            Enum.TryParse<AracDurumu>(cmbAracDurumu.SelectedItem.ToString(), out durum);
            Arac a1 = new Arac(txtModel.Text, txtMarka1.Text, txtYakitTipi.Text, Convert.ToDateTime(txtUretimTarihi.Text), Convert.ToInt32(txtGunlukUcret.Text), durum);
            _vb.AracListesi.Add(a1);
            //listBox1.Items.Add(a1);
            listBox1.DataSource = _vb.AracListesi;
            listBox1.DisplayMember = _vb.AracListesi[0].Marka;
            
           
        }
    }
}
