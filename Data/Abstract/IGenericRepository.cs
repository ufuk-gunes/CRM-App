using MixCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Data.Abstract
{
    public interface IGenericRepostory<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(int id);
        void Update(TEntity entity);
        void Insert(TEntity entity);
        IEnumerable<Departman> GetDepartmanByFilter(string name = null);
        IEnumerable<Firma> GetFirmaByFilter(string name = null,string FirYet = null);
        IEnumerable<Kategori> GetKategoriByFilter(string name = null);
        IEnumerable<Urun> GetUrunByFilter(string name = null);
        IEnumerable<Musteri> GetMusteriByFilter(string name = null, string lastname = null);
        IEnumerable<Personel> GetPersonelByFilter(string name = null);
        IEnumerable<Satis> GetSatisByFilter(string name = null);
        IEnumerable<Stok> GetStokByFilter(string name = null);
        IEnumerable<Teklif> GetTeklifByFilter(string name = null);

        IEnumerable<Kategori> GetKategoriler();
        IEnumerable<Firma> GetFirmalar();
        IEnumerable<Departman> GetDepartmanlar();
        IEnumerable<Urun> GetUrunler();
        IEnumerable<Musteri> GetMusteriler();
        IEnumerable<Personel> GetPersoneller();
        IEnumerable<Stok> GetStoklar();

    }
}
