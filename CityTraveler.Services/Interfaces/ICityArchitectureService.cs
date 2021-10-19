
using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ICityArchitectureService : IServiceMetadata
    {
        public Task<bool> AddObjectToCity(InstitutionModel institution);
        public Task<bool> AddObjectToCity(EventModel ev);
        public Task<bool> AddObjectToCity(LandskapeModel landskape);
        public Task<bool> UpdateCityObject(InstitutionModel institution);
        public Task<bool> UpdateCityObject(EventModel ev);
        public Task<bool> UpdateCityObject(LandskapeModel landskape);
        public Task<bool> RemoveObjectById(Guid objectId, PlaceType type);
        public Task<bool> AddStreet(StreetModel street);
        public Task<bool> UpdateStreet(StreetModel street);
        public Task<bool> RemoveStreet(Guid streetId);
        public Task<bool> BuildCityMap();
        public Task<bool> ValidateCityMap();
    }   
}

