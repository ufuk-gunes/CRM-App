using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;

namespace MixCRM.Controllers
{
    public class PersonelController : Controller
    {
        private IGenericRepostory<Personel> repo;
        public PersonelController(IGenericRepostory<Personel> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var departmanlar = repo.GetDepartmanlar();
            ViewBag.Departmanlar = departmanlar;

            var personel = repo.GetPersonelByFilter(name);
            ViewBag.Name = name;
            return View(personel);
        }
        public IActionResult Edit(int id)
        {
            var departmanlar = repo.GetDepartmanlar();
            ViewBag.Departmanlar = departmanlar;

            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Personel entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            var departmanlar = repo.GetDepartmanlar();
            ViewBag.Departmanlar = departmanlar;

            ViewBag.ActionMode = "Create";
            return View("Edit", new Personel());
        }
        [HttpPost]

        public IActionResult Create(Personel newPersonel)
        {
            repo.Insert(newPersonel);
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