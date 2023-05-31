using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu.Veri.Concrets
{
    public class VeriTutulanKisim
    {
        public List<Kullanici> KullaniciListesi { get; set; } = new();
        public List<Arac> AracListesi { get; set; } = new();
    }
}
