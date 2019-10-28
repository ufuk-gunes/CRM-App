using MixCRM.Data.Abstract;
using MixCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Data.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepostory<TEntity> where TEntity : class
    {
        private DataContext db;
        public GenericRepository(DataContext _db)
        {
            db = _db;
        }
        public void Delete(int id)
        {
            db.Remove<TEntity>(Get(id));
            db.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public IEnumerable<Departman> GetDepartmanByFilter(string name = null)
        {
            IQueryable<Departman> query = db.Departmen;
            if (name != null)
            {
                query = query.Where(x => x.Ad.ToLower().Contains(name.ToLower()));
            }
            
            return query.ToList();
        }

        public IEnumerable<Departman> GetDepartmanlar()
        {
            return db.Set<Departman>();
        }

        public IEnumerable<Firma> GetFirmaByFilter(string name = null, string FirYet = null)
        {
            IQueryable<Firma> query = db.Firmas;

            if (name != null)
            {
                query = query.Where(x => x.FirmaAdi.ToLower().Contains(name.ToLower()));
            }
            if (FirYet != null)
            {
                query = query.Where(x => x.FirmaYetkilisi.ToLower().Contains(FirYet.ToLower()));
            }

            return query.ToList();
        }

        public IEnumerable<Firma> GetFirmalar()
        {
            return db.Set<Firma>();
        }

        public IEnumerable<Kategori> GetKategoriByFilter(string name = null)
        {
            IQueryable<Kategori> query = db.Kategoris;

            if (name != null)
            {
                query = query.Where(x => x.Ad.ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Kategori> GetKategoriler()
        {
            return db.Set<Kategori>();
        }

        public IEnumerable<Musteri> GetMusteriByFilter(string name = null, string lastname = null)
        {
            IQueryable<Musteri> query = db.Musteris;

            if (name != null)
            {
                query = query.Where(x => x.Ad.ToLower().Contains(name.ToLower()));
            }
            if (lastname != null)
            {
                query = query.Where(x => x.Soyad.ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Musteri> GetMusteriler()
        {
            return db.Set<Musteri>();
        }

        public IEnumerable<Personel> GetPersonelByFilter(string name = null)
        {
            IQueryable<Personel> query = db.Personels;

            if (name != null)
            {
                query = query.Where(x => x.Ad.ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Personel> GetPersoneller()
        {
            return db.Set<Personel>();
        }

        public IEnumerable<Satis> GetSatisByFilter(string name = null)
        {
            IQueryable<Satis> query = db.Satis;

            if (name != null)
            {
                query = query.Where(x => x.SatisAdi.ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Stok> GetStokByFilter(string name = null)
        {
            IQueryable<Stok> query = db.Stoks;

            if (name != null)
            {
                query = query.Where(x => x.Urun.ToString().ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Stok> GetStoklar()
        {
            return db.Set<Stok>();
        }

        public IEnumerable<Teklif> GetTeklifByFilter(string name = null)
        {
            IQueryable<Teklif> query = db.Teklifs;

            if (name != null)
            {
                query = query.Where(x => x.TeklifAdi.ToLower().Contains(name.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Urun> GetUrunByFilter(string name = null)
        {
            IQueryable<Urun> query = db.Uruns;

            if (name != null)
            {
                query = query.Where(x => x.UrunAdi.ToLower().Contains(name.ToLower()));
            }  
            return query.ToList();
        }

        public IEnumerable<Urun> GetUrunler()
        {
            return db.Set<Urun>();
        }
        

        public void Insert(TEntity entity)
        {
            db.Add<TEntity>(entity);
            db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            db.Update<TEntity>(entity);
            db.SaveChanges();
        }
    }
}
