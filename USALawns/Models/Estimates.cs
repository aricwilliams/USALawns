using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace USALawns.Models
{
    public class Estimates
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Job { get; set; }
        public int Quantity { get; set; }
        public string Customer { get; set; }
        public string Date { get; set; }
    }
}
