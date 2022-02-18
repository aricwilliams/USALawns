using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorNC.Models.ViewModels
{
    public class AppointmentVM
    {

        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Duration { get; set; }
        public string RealtorId { get; set; }
        public string ProspectId { get; set; }
        public bool IsRealtorApproved { get; set; }
        public string AdminId { get; set; }

        public string RealtorName { get; set; }
        public string ProspectName { get; set; }
        public string AdminName { get; set; }
        public bool IsForProspect { get; set; }
    }
}
