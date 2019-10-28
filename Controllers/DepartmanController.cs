using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MixCRM.Data.Abstract;
using MixCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace MixCRM.Controllers
{
    public class DepartmanController : Controller
    {
        private IGenericRepostory<Departman> repo;
        public DepartmanController(IGenericRepostory<Departman> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name = null)
        {
            var departman = repo.GetDepartmanByFilter(name);
            ViewBag.Name = name;
            return View(departman);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Departman entity)
        {
            repo.Update(entity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Departman());
        }
        [HttpPost]

        public IActionResult Create(Departman newDepartman)
        {
            repo.Insert(newDepartman);
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