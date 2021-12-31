using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31122021FromApp
{
    public interface Iogrenci
    {
         int ogrenciId { get; set; }
         string ogrenciAd { get; set; }
        string ogrenciSoyad { get; set; }
        decimal ogrenci1Sinav { get; set; }

        decimal ogrenci2Sinav { get; set; }
        decimal ortalama { get; set; }

        decimal oortalama();
    }
}
