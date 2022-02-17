using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Data;
using USALawns.Models;

namespace USALawns.Services
{
    //this will be the database operation Jobs controller can call this when need to do database operation
    public class JobService : IJobService
    {
        private readonly ApplicationDBContext _db;
        public JobService(ApplicationDBContext db)
        {
            _db = db;
        }
        public List<Jobs> GetJobsList()
        {
            var jobs = (from job in _db.Jobs
                            //this is projection, we only getting some columns
                        select new Jobs
                        {
                            Id = job.Id,
                            Description = job.Description
                        }
                        ).ToList();
            return jobs;
        }
    }
}
