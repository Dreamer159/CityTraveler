using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ICityArchitectureService : IServiceMetadata
    {
        public bool AddObjectToCity(IInstitution entertaiment);
        public bool AddObjectToCity(IEvent ev);
        public bool AddObjectToCity(ILandskape landskape);
        public bool UpdateCityObject(IInstitution entertaiment);
        public bool UpdateCityObject(IEvent ev);
        public bool UpdateCityObject(ILandskape landskape);
        public bool RemoveObjectById(Guid objectId);
        public bool AddStreet(IStreet street);
        public bool UpdateStreet(IStreet street);
        public bool RemoveStreet(Guid streetId);
        public bool BuildCityMap();
        public bool ValidateCityMap();
    }   
}

