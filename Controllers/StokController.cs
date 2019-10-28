using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class StokController : Controller
    {
        private IGenericRepostory<Stok> repo;
        public StokController(IGenericRepostory<Stok> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;

            var stok = repo.GetStokByFilter(name);
            ViewBag.Name = name;
            return View(stok);
        }
        public IActionResult Edit(int id)
        {
            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;  

            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Stok entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var urunler = repo.GetUrunler();
            ViewBag.Urunler = urunler;

            ViewBag.ActionMode = "Create";
            return View("Edit", new Stok());
        }
        [HttpPost]

        public IActionResult Create(Stok newStok)
        {
            repo.Insert(newStok);
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