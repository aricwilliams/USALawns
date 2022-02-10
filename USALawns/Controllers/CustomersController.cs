using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace USALawns.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CustomersController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Customers> objList = _db.Customers;
            return View(objList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customers obj)
        {
           // if (Model.State.IsValid)
           // {
                _db.Customers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
           // }
           // return View(obj);
          
        }

        //Get-Delete-pull up that specific record, show on screen... this use delete view
        public IActionResult Delete(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Customers.Find(id);
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
            var obj = _db.Customers.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Customers.Remove(obj);
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
            var obj = _db.Customers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //PostUpdate-Save that delete to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Customers obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
