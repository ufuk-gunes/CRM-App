using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal AlisFiyati { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
       

    }
}
