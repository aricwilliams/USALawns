using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace USALawns.Models
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        //public bool Job { get; set; }
        public string Job { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public bool Recuring { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
