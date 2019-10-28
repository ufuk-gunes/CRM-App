using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class FirmaController : Controller
    {
        private IGenericRepostory<Firma> repo;
        public FirmaController(IGenericRepostory<Firma> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null, string FirYet = null)
        {
            var firma = repo.GetFirmaByFilter(name, FirYet);
            ViewBag.name = name;
            ViewBag.FirYet = FirYet;
            return View(firma);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Firma entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Firma());
        }

        [HttpPost]
        public IActionResult Create(Firma newFirma)
        {
            repo.Insert(newFirma);
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