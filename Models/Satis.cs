using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Satis
    {
        public int Id { get; set; }
        public string SatisAdi { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
        public int UrunId { get; set; }
        public int SatisAdeti { get; set; }        
        public string Aciklama { get; set; }        
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }
    }
}
