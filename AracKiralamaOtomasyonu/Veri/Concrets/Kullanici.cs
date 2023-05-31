using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu.Veri.Concrets
{
    public class Kullanici : VeriTutulanKisim
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }

        public Kullanici(string ad, string soyad, string eposta, string sifre)
        {
            Ad = ad;
            Soyad = soyad;
            Eposta = eposta;
            Sifre = sifre;

        }
      








    }
}
