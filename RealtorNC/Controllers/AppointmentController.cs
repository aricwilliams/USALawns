using Microsoft.AspNetCore.Mvc;
using RealtorNC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealtorNC.Utility;

namespace RealtorNC.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public IActionResult Index()
        {
           ViewBag.RealtorList = _appointmentService.GetRealtorList();
           ViewBag.Duration = Helper.GetTimeDropDown();
           ViewBag.ProspectList = _appointmentService.GetProspectList();

            return View();
        }
    }
}
