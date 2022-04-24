using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CagriMerkezi
{
    public class BireyselMusteriHizmetleri:MusteriHizmetleri
    {
        public List<BireyselMusteriHizmetleri> Calisanlar { get; set; }

        public BireyselMusteriHizmetleri()
        {
            Calisanlar = new List<BireyselMusteriHizmetleri>();
        }

        public void Ekle(BireyselMusteriHizmetleri bireysel)
        {
            Calisanlar.Add(bireysel);
        }

    

    }
}
