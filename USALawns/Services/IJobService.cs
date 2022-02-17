using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Models;

namespace USALawns.Services
{
    public interface IJobService
    {
        public List<Jobs> GetJobsList();
    }
}
