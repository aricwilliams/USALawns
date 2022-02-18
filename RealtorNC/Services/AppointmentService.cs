using RealtorNC.Models;
using RealtorNC.Models.ViewModels;
using RealtorNC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorNC.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;
        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;

        }
        public List<RealtorVM> GetRealtorList()
        {
            var realtors = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x => x.Name == Helper.Realtor) on userRoles.RoleId equals roles.Id
                            select new RealtorVM
                            {
                                Id = user.Id,
                                Name = user.Name
                            }
                            ).ToList();
            return realtors;
        }
        public List<ProspectVM> GetProspectList()
        {
            var prospects = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x => x.Name == Helper.Prospect) on userRoles.RoleId equals roles.Id
                            select new ProspectVM
                            {
                                Id = user.Id,
                                Name = user.Name
                            }
                           ).ToList();
            return prospects;
        }

        public async Task<int> AddUpdate(AppointmentVM model)
        {
            var startDate = DateTime.Parse(model.StartDate);
            var endDate = DateTime.Parse(model.StartDate).AddMinutes(Convert.ToDouble(model.Duration));
            if (model != null && model.Id > 0)
            {
                //update
                return 1;
               
            }
            else
            {
                //create
                Appointment appointment = new Appointment()
                {
                    Title = model.Title,
                    Description = model.Description,
                    StartDate = startDate,
                    EndDate = endDate,
                    Duration = model.Duration,
                    RealtorId = model.RealtorId,
                    ProspectId = model.ProspectId,
                    IsRealtorApproved = false,
                    AdminId = model.AdminId
                };
                
                _db.Appointments.Add(appointment);
                await _db.SaveChangesAsync();
                return 2;
            }

        }
    }
}

