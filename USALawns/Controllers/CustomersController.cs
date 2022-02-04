using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;

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
    }
}
