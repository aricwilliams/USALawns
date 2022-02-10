using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;

namespace USALawns.Controllers
{
    public class EstimatesController : Controller
    {
        private readonly ApplicationDBContext _db;
        public EstimatesController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Estimates> objList = _db.Estimates;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estimates obj)
        {
           if (ModelState.IsValid)
            {
            _db.Estimates.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
           }
            return View(obj);

        }

        //Get-Delete-pull up that specific record, show on screen... this use delete view
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Estimates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //POST-Delete-Save that delete to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Estimates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Estimates.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Get-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Estimates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //PostUpdate-Save that delete to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Estimates obj)
        {
            if (ModelState.IsValid)
            {
                _db.Estimates.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
