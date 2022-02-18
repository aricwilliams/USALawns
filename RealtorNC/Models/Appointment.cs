﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorNC.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public string RealtorId { get; set; }
        public string ProspectId { get; set; }
        public bool IsRealtorApproved { get; set; }
        public string AdminId { get; set; }
    }
}