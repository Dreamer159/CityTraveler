using CityTraveler.Domain.Entities;
using CityTraveler.Repository.DbContext;
using CityTraveler.Services.Interfaces;
using CityTraveler.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CityTraveler.Services
{
    class AdminPanelService : IAdminPanelService
    {
        private ApplicationContext _context;
        public AdminPanelService(ApplicationContext context)
        {
            _context = context;
        }
    }
}
