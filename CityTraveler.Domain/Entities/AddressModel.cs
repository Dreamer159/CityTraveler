using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Domain.Entities
{
    public class AddressModel : Entity
    {
        public virtual CoordinatesModel Coordinates { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        
    }

    public class StreetAddressModel : AddressModel
    {
        public virtual StreetModel Street { get; set; }
    }

    public class EntertaimentAddressModel : AddressModel
    {
        //public virtual LandskapeModel Landskapes { get; set;}
        //public virtual InstitutionModel Institutions { get; set;}
        //public virtual EventModel eventModel { get; set; }

        public virtual Entertaiment Entertaiments { get; set; }

    }
}
