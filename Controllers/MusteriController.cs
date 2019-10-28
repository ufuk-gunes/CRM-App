using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class MusteriController : Controller
    {
        private IGenericRepostory<Musteri> repo;
        public MusteriController(IGenericRepostory<Musteri> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null, string lastname = null)
        {
            var firmalar = repo.GetFirmalar();
            ViewBag.Firmalar = firmalar;

            var musteri = repo.GetMusteriByFilter(name,lastname);
            ViewBag.Name = name;
            ViewBag.Last = lastname;
            return View(musteri);
        }
        public IActionResult Edit(int id)
        {
            var firmalar = repo.GetFirmalar();
            ViewBag.Firmalar = firmalar;

            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Musteri entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var firmalar = repo.GetFirmalar();
            ViewBag.firmalar = firmalar;

            ViewBag.ActionMode = "Create";
            return View("Edit", new Musteri());
        }
        [HttpPost]

        public IActionResult Create(Musteri newMusteri)
        {
            repo.Insert(newMusteri);
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