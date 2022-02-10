using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace USALawns.Models
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        //public bool Job { get; set; }
        //this is data annotation
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Recuring")]
        public bool Recuring { get; set; }
        [DisplayName("Start")]
        public string Start { get; set; }
        [DisplayName("End")]
        public string End { get; set; }

        [DisplayName("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customers Customers { get; set; }
    }
}
