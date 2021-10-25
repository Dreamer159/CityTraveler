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
    class StatisticService : IStatisticService
    {
        // 
        private ApplicationContext _context;
        public StatisticService(ApplicationContext context)
        {
            _context = context;
        }

    }
}
