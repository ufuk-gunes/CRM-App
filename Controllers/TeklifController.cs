using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class TeklifController : Controller
    {
        private IGenericRepostory<Teklif> repo;
        public TeklifController(IGenericRepostory<Teklif> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var teklif = repo.GetTeklifByFilter(name);
            ViewBag.Name = name;
            return View(teklif);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Teklif entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Teklif());
        }
        [HttpPost]

        public IActionResult Create(Teklif newTeklif)
        {
            repo.Insert(newTeklif);
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