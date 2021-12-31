using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31122021FromApp
{
    public class Ortalama : Iogrenci
    {
        public int ogrenciId { get; set ; }
        public string ogrenciAd { get; set; }
        public string ogrenciSoyad { get; set; }
        public decimal ogrenci1Sinav { get; set; }
        public decimal ogrenci2Sinav { get; set; }
        public decimal ortalama { get; set; }

      public  decimal oortalama( )
        {
            decimal ortalama = (ogrenci1Sinav + ogrenci2Sinav) / 2;
            return (decimal) ortalama;
        }
    }
}
