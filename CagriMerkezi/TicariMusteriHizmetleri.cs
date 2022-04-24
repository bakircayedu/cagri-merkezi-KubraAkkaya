using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    public class TicariMusteriHizmetleri:MusteriHizmetleri
    {
        public List<TicariMusteriHizmetleri> Calisanlar { get; set; }

        public TicariMusteriHizmetleri()
        {
            Calisanlar = new List<TicariMusteriHizmetleri>(); 
        }

        public void Ekle(TicariMusteriHizmetleri ticari)
        {
            Calisanlar.Add(ticari);
        }

    }
}
