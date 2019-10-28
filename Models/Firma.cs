using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Firma
    {
        public int Id { get; set; }

        public string FirmaAdi { get; set; }

        public string Unvan { get; set; }

        public string Eposta { get; set; }

        public string Tel { get; set; }

        public string FirmaYetkilisi { get; set; }

        public string Adres { get; set; }

        public string Aciklama { get; set; }
    }
}
