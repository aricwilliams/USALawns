using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;

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
            return View(objList);
        }
    }
}

