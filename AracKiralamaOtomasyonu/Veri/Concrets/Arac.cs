using AracKiralamaOtomasyonu.Veri.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu.Veri.Concrets
{
    public class Arac
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public string YakitTipi { get; set; }
        public DateTime UretimTarihi { get; set; }
        public int GunlukUcret { get; set; }
        public AracDurumu AracDurumu { get; set; }

        public Arac(string model, string marka, string yakitTipi, DateTime uretimTarihi, int gunlukucret, AracDurumu aracDurumu)
        {
            Model = model;
            Marka = marka;
            YakitTipi = yakitTipi;
            UretimTarihi = uretimTarihi;
            GunlukUcret = gunlukucret;
            AracDurumu = aracDurumu;
        }
        public override string ToString()
        {
            return $"{Marka} {Model} {YakitTipi} {UretimTarihi} {GunlukUcret} {AracDurumu}";
        }
    }
}
