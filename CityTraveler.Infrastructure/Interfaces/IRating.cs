using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace CityTraveler.Infrastructure.Interfaces
{
    public interface IRating : IDbData
    {
        public Guid OwnerId { get; set; }
        public double Value { get; set; }
    }
}
