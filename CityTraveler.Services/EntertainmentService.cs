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
    public class EntertainmentService : IEntertainmentService
    {
        ApplicationContext _context;
        public EntertainmentService(ApplicationContext context) 
        {
            _context = context;
        }
        
        public IEnumerable<EntertaimentModel> GetAll()
        {
            return (IEnumerable<EntertaimentModel>)_context.Entertaiments;
        }
        
        public IEnumerable<EntertaimentModel> GetEntartainmentByMinRating(int averageRating)
        {
            return (IEnumerable<EntertaimentModel>)_context.Entertaiments
                .SelectMany(x => x.Trips.Where(y => y.AverageRating > averageRating)).Select(x => x.Entertaiment);
        }
        public IEnumerable<EntertaimentModel> GetEntartainmentByMaxRating(int averageRating)
        {
            return (IEnumerable<EntertaimentModel>)_context.Entertaiments
                .SelectMany(x => x.Trips.Where(y => y.AverageRating < averageRating)).Select(x => x.Entertaiment);
        }

        public EntertaimentModel GetEntertainmentByCoordinates(CoordinatesModel coordinates)
        {
            return _context.Entertaiments
                .Where(x => x.Address.Coordinates == coordinates).FirstOrDefault();
        }

        public EntertaimentModel GetEntertainmentById(Guid id)
        {
            return _context.Entertaiments
                .Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<EntertaimentModel> GetEntertainmentsByStreet(StreetModel street)
        {
            return _context.Entertaiments
                .Where(x => x.Address.Street == street);
        }

        public EntertaimentModel GetEntertainmentByTitle(string title)
        {
            return _context.Entertaiments.Where(x=>x.Title == title).FirstOrDefault();
        }

        public IEnumerable<EntertaimentModel> GetEntertainments(IEnumerable<Guid> ids)
        {
            var result = new List<EntertaimentModel>();
            foreach (var id in ids)
            {
                result.Add(_context.Entertaiments.Where(x => x.Id == id).FirstOrDefault());
            }
            return result;
        }

        public bool RemoveEntertainment(Guid id)
        {
            try
            {
                _context.Entertaiments.Remove(_context.Entertaiments.Where(x => x.Id == id).FirstOrDefault());
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SetEntertaiment(IEnumerable<EntertaimentModel> entertaiments)
        {
            try
            {
                _context.Entertaiments = (DbSet<EntertaimentModel>)entertaiments;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateEntertainment(EntertaimentModel entertaiment)
        {
            try
            {
                _context.Entertaiments.Remove(_context.Entertaiments.Where(x => x.Id == entertaiment.Id).FirstOrDefault());
                _context.Entertaiments.Add(entertaiment);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddEntertainment(EntertaimentModel entertaiment)
        {
            try
            {
                _context.Entertaiments.Add(entertaiment);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
