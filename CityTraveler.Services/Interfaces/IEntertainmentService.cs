using CityTraveler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface IEntertainmentService
    {
        public bool AddEntertainment(EntertaimentModel entertaiment);
        public bool SetEntertaiment(IEnumerable<EntertaimentModel> entertaiments);
        public bool UpdateEntertainment(EntertaimentModel entertaiment);
        public bool RemoveEntertainment(Guid id);
        public IEnumerable<EntertaimentModel> GetAll();
        public IEnumerable<EntertaimentModel> GetEntertainments(IEnumerable<Guid> guids);
        public EntertaimentModel GetEntertainmentById(Guid guids);
        public EntertaimentModel GetEntertainmentByTitle(string title);
        public IEnumerable<EntertaimentModel> GetEntertainmentsByStreet(StreetModel street);
        public EntertaimentModel GetEntertainmentByCoordinates(CoordinatesModel street);
        public IEnumerable<EntertaimentModel> GetEntartainmentByMinRating(int averageRating);
        public IEnumerable<EntertaimentModel> GetEntartainmentByMaxRating(int averageRating);

    }
}
