using RealtorNC.Models;
using RealtorNC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorNC.Services
{
    public interface IAppointmentService
    {

        public List<ProspectVM> GetProspectList();

        public List<RealtorVM> GetRealtorList();
        public Task<int> AddUpdate(AppointmentVM model);

    }
}
