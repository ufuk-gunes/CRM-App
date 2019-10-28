using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class KategoriController : Controller
    {
        private IGenericRepostory<Kategori> repo;
        public KategoriController(IGenericRepostory<Kategori> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var kategori = repo.GetKategoriByFilter(name);
            ViewBag.Name = name;
            return View(kategori);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Kategori entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Kategori());
        }
        [HttpPost]

        public IActionResult Create(Kategori newKategori)
        {
            repo.Insert(newKategori);
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