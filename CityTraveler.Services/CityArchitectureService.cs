using CityTraveler.Infrastructure.Interfaces;
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
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool AddObjectToCity(IInstitution entertaiment)
        {
            throw new NotImplementedException();
        }

        public bool AddObjectToCity(IEvent ev)
        {
            throw new NotImplementedException();
        }

        public bool AddObjectToCity(ILandskape landskape)
        {
            throw new NotImplementedException();
        }

        public bool AddStreet(IStreet street)
        {
            throw new NotImplementedException();
        }

        public bool BuildCityMap()
        {
            throw new NotImplementedException();
        }

        public bool RemoveObjectById(Guid objectId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStreet(Guid streetId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCityObject(IInstitution entertaiment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCityObject(IEvent ev)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCityObject(ILandskape landskape)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStreet(IStreet street)
        {
            throw new NotImplementedException();
        }

        public bool ValidateCityMap()
        {
            throw new NotImplementedException();
        }
    }
}
