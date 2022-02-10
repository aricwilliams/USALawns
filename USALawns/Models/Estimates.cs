using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace USALawns.Models
{
    public class Estimates
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount Must be Greater Than 0!")]
        [DisplayName("Amount")]
        public int Amount { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Customer")]
        public string Customer { get; set; }
        [DisplayName("Date")]
        public string Date { get; set; }
    }
}

//for amount<div>asp-validation-summary="ModelOnly" class="text-danger"></div>
//under input <span asp-validation-for="same as asp-for" class="text-danger"></span>

//in controller 
//if(ModelState.IsValid)
//{
//run the same code
//
//}
//return View(obj);