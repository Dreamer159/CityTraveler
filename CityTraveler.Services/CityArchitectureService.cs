using CityTraveler.Domain.Entities;
using CityTraveler.Infrastucture.Data;
using CityTraveler.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class CityArchitectureService : ICityArchitectureService
    {
        private readonly ApplicationContext _dbContext;
        public bool IsActive { get; set; }
        public string Version { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public CityArchitectureService(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*public async Task<bool> AddObjectToCity(IEvent ev)
        {
            _dbContext.Events.Collection.Add(ev);

            var query = $"";

            var affectedObjects = await _dbContext.Events.RequestManager.SendRequestAsync(query, null, false);
            return affectedObjects > 0;
        }

        public async Task<bool> AddObjectToCity(ILandskape landskape)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddStreet(IStreet street)
        {
            _dbContext.Streets.Collection.Add(street);

            var query = $"";

            var affectedObjects = await _dbContext.Streets.RequestManager.SendRequestAsync(query, null, false);
            return affectedObjects > 0;
        }

        public async Task<bool> BuildCityMap()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveObjectById(Guid objectId, PlaceType type)
        {
            switch (type)
            {
                case PlaceType.Event:
                    _dbContext.Events.Collection.RemoveAll(x => x.Id == objectId);
                    break;
                case PlaceType.Institution:
                    _dbContext.Institutions.Collection.RemoveAll(x => x.Id == objectId);
                    break;
                case PlaceType.Landscape:
                    _dbContext.Landskapes.Collection.RemoveAll(x => x.Id == objectId);
                    break;
                default:
                    break;
            }

            var query = $"";

            var affectedObjects = await _dbContext.Events.RequestManager.SendRequestAsync(query, null, false);
            return affectedObjects > 0;
        }

        public async bool RemoveStreet(Guid streetId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCityObject(IInstitution institute)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCityObject(IEvent ev)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCityObject(ILandskape landskape)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateStreet(IStreet street)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateCityMap()
        {
            throw new NotImplementedException();
        }
*/
        public async Task<bool> AddEntertainmentToCity(EntertaimentModel entertaiment)
        {
            try
            {
                _dbContext.Entertaiments.Add(entertaiment);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw new DbInitializationException("Failed to add entertainment");
                //return false;
            }
            return true;
        }

        public async Task<bool> UpdateCityEntertainment(EntertaimentModel entertaiment)
        {
            try
            {
                DbSet<EntertaimentModel> en = (DbSet<EntertaimentModel>)_dbContext.Entertaiments.Where(x => x.Id != entertaiment.Id);
                _dbContext.Entertaiments.Add(entertaiment);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
    
        }

        public async Task<bool> RemoveEntertainmentById(Guid objectId)
        {
            try
            {
                _dbContext.Entertaiments = (DbSet<EntertaimentModel>)_dbContext.Entertaiments.Where(x => x.Id != objectId);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public async Task<bool> AddStreet(StreetModel street)
        {
            try
            {
                _dbContext.Streets.Add(street);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateStreet(StreetModel street)
        {
            try
            {
                DbSet<StreetModel> en = (DbSet<StreetModel>)_dbContext.Entertaiments.Where(x => x.Id != street.Id);
                _dbContext.Streets.Add(street);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public async Task<bool> RemoveStreet(Guid streetId)
        {
            try
            {
                _dbContext.Streets = (DbSet<StreetModel>)_dbContext.Entertaiments.Where(x => x.Id != streetId);
               await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public Task<bool> BuildCityMap()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCityMap()
        {
            throw new NotImplementedException();
        }

        public StreetModel FindStreetByCoordinates(Guid coordID)
        {
            AddressModel ad =  _dbContext.Addresses.FirstOrDefault(x=>x.CoordinatesId == coordID);
            return ad.Street;
        }

        public AddressModel FindAddressByCoordinates(Guid coordID)
        {
            return _dbContext.Addresses.FirstOrDefault(x => x.CoordinatesId == coordID);
        }

        public IEnumerable<EntertaimentModel> FindEntertainmentByStreet(Guid streetId)
        {
            return _dbContext.Entertaiments.Where(x=>x.Address.StreetId == streetId);
        }

        public IEnumerable<EntertaimentModel> FindEntertainmentByCoordinate(Guid coorId)
        {
            return _dbContext.Entertaiments.Where(x => x.Address.CoordinatesId == coorId);
        }

        public IEnumerable<EntertaimentModel> FindEntertainmentByAddress(Guid addressId)
        {
            return _dbContext.Entertaiments.Where(x => x.Address.StreetId == addressId);
        }

        public AddressModel FindAddressByStreetHouse(Guid streetId, string houseNum)
        {
            return _dbContext.Addresses.FirstOrDefault(x=>x.StreetId == streetId && x.HouseNumber == houseNum);
        }

        public IEnumerable<AddressModel> FindAddressByHouse(string houseNum)
        {
            return _dbContext.Addresses.Where(x => x.HouseNumber == houseNum);
        }

        public IEnumerable<EntertaimentModel> FindEntertainmentByStreetTitle(string streetTitle)
        {
            return _dbContext.Entertaiments.Where(x => x.Address.Street.Title == streetTitle);
        }
    }
}
