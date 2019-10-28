using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Email { get; set; }
        public DateTime DTarih { get; set; }
        public string Foto { get; set; }
        public string Adres { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }

    }
}
