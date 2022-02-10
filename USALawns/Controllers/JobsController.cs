using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;
using USALawns.Models.ViewModels;

namespace USALawns.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDBContext _db;
        public JobsController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Jobs> objList = _db.Job;

            //this loop will allow me to get the customer name in the Jobs database, curently only have the customerID
            foreach(var obj in objList)
            {
                //for everysingle object in that object list set the customer to the 1st entry you find for the ID we have right now... Plain words= we have the customerID, give me the customer for that ID
                obj.Customers = _db.Customers.FirstOrDefault(u => u.Id == obj.CustomerId);
            }

            return View(objList);
        }
        public IActionResult Create()
        {
            //use _db to get list of customers from the database.... this is the database connection
            //IEnumerable<SelectListItem> TypeDropDown = _db.Customers.Select(i => new SelectListItem
            //{
            //this is visiable to the user
            //Text = i.Name,
            //this value is the value of the text
            // Value = i.Id.ToString()
            //});
            //storing our Typedropdown in the position of same name inside the viewbag
            //ViewBag.TypeDropDown = TypeDropDown;

            //Instead of using viewbag above
            JobsVM JobsVM = new JobsVM()
            {
                Jobs = new Jobs(),
                TypeDropDown = _db.Customers.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            return View(JobsVM);
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobsVM obj)
        {
            if (ModelState.IsValid)
            {
            _db.Job.Add(obj.Jobs);
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
            var obj = _db.Job.Find(id);
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
            var obj = _db.Job.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Job.Remove(obj);
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
            var obj = _db.Job.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        //PostUpdate-Save that delete to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Jobs obj)
        {
            if (ModelState.IsValid)
            {
                _db.Job.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}

