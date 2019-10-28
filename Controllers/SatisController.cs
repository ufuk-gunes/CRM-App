using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class SatisController : Controller
    {
        private IGenericRepostory<Satis> repo;
        public SatisController(IGenericRepostory<Satis> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var stoklar = repo.GetStoklar();
            ViewBag.Stoklar = stoklar;

            var musteriler = repo.GetMusteriler();
            ViewBag.Musteriler = musteriler;

            var personeller = repo.GetPersoneller();
            ViewBag.Personeller = personeller;

            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;

            var satis = repo.GetSatisByFilter(name);
            ViewBag.Name = name;
            return View(satis);
        }
        public IActionResult Edit(int id)
        {
            var musteriler = repo.GetMusteriler();
            ViewBag.Musteriler = musteriler;

            var personeller = repo.GetPersoneller();
            ViewBag.Personeller = personeller;

            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;

            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Satis entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var musteriler = repo.GetMusteriler();
            ViewBag.Musteriler = musteriler;

            var personeller = repo.GetPersoneller();
            ViewBag.Personeller = personeller;

            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;

            ViewBag.ActionMode = "Create";
            return View("Edit", new Satis());
        }
        [HttpPost]

        public IActionResult Create(Satis newSatis)
        {
            repo.Insert(newSatis);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}