using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Stok
    {
        public int Id { get; set; }
        public int StokAdet { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }

    }
}
