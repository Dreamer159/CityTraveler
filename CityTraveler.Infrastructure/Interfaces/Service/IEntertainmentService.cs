using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Infrastructure.Interfaces.Service
{
    public interface IEntertainmentService
    {
        IEnumerable<IEntertaiment> Entertainments { get; set; }
        public bool SetEntertaiment(IEnumerable<IEntertaiment> entertaiments);
        public bool UpdateEntertainment(IEntertaiment entertaiments);
        public bool RemoveEntertainment(Guid id);
        public IEnumerable<IEntertaiment> GetAll();
        public IEnumerable<IEntertaiment> GetEntertainments(IEnumerable<Guid> guids);
        public IEntertaiment GetEntertainmentById(Guid guids);
        public IEntertaiment GetEntertainmentByTitle(string title);
        public IEntertaiment GetEntertainmentByStreet(IStreet street);
        public IEntertaiment GetEntertainmentByCoordinates(ICoordinates street);
        public bool UpdateEntertainment(IEntertaiment entertaiment);




    }
}
