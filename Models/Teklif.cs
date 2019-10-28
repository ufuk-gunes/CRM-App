using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Teklif
    {
        public int Id { get; set; }
        public string TeklifAdi { get; set; }
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }

        public int PersonelId { get; set; }
        public int MusteriId { get; set; }
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }

    }
}
