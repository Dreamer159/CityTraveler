using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Enums;
using CityTraveler.Repository.DbContext;
using CityTraveler.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class CityArchitectureService : ICityArchitectureService
    {
        public bool IsActive { get; set; }
        public string Version { get; set; }

        public Task<bool> AddObjectToCity(InstitutionModel institution)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddObjectToCity(EventModel ev)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddObjectToCity(LandskapeModel landskape)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddStreet(StreetModel street)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BuildCityMap()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveObjectById(Guid objectId, PlaceType type)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveStreet(Guid streetId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCityObject(InstitutionModel institution)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCityObject(EventModel ev)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCityObject(LandskapeModel landskape)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStreet(StreetModel street)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCityMap()
        {
            throw new NotImplementedException();
        }
    }
}
