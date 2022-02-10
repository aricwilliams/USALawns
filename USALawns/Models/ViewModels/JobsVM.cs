using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USALawns.Models.ViewModels
{
    public class JobsVM
    {
        //combine jobs & customer ID
        public Jobs Jobs { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
