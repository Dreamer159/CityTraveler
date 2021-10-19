using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using CityTraveler.Domain.Enums;
    
namespace CityTraveler.Domain.Entities
{
    public class Entertaiment : Entity, IDescribable
    {
        public virtual ICollection<EntertaimentImageModel> Images { get; set; } = new List<EntertaimentImageModel>();
        public virtual ICollection<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();
        public virtual EntertaimentAddressModel Address { get; set; }
        public virtual EntertainmentType Type { get; set; }
        public virtual ICollection<TripModel> Trips { get; set; } = new List<TripModel>();
        public virtual ICollection<EntertaimentPriceModel> Prices { get; set; } = new List<EntertaimentPriceModel>();
        public string Title { get; set; }
        public string Description { get; set; }

        //Need to create a json for institution's and event's properties  
    }
}
