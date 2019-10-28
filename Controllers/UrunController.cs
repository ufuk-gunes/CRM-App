using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class UrunController : Controller
    {
        private IGenericRepostory<Urun> repo;
        public UrunController(IGenericRepostory<Urun> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var kategoriler = repo.GetKategoriler();
            ViewBag.kategoriler = kategoriler;

            var urun = repo.GetUrunByFilter(name);
            ViewBag.Name = name;
            return View(urun);
        }
        public IActionResult Edit(int id)
        {
            var kategoriler = repo.GetKategoriler();
            ViewBag.kategoriler = kategoriler;

            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Urun entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var kategoriler = repo.GetKategoriler();
            ViewBag.Kategoriler = kategoriler;

            ViewBag.ActionMode = "Create";
            return View("Edit", new Urun());
        }
        [HttpPost]

        public IActionResult Create(Urun newUrun)
        {
            repo.Insert(newUrun);
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