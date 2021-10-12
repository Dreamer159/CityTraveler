using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    class Way
    {
        public Way()
        {

        }
  
        string Name { get; set; }

        // Need to change type of PointList
        string PointList { get; set; }

        //Need to change type of owner
        string Owner { get; set; }

        DateTime RoadTime { get; set; }

        bool IsCompleted { get; set; }

        // Need to create class Trip?
        DateTime TripDate { get; set; }
        //from completed way

       // string Name { get; set; }

        string Description { get; set; }

        // Need to change type of Feedback
        string Feedback { get; set; }

        int Cost { get; set; }

        DateTime PostingDate { get; set; }



    }
}
