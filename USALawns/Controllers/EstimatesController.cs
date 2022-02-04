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
    }
}
