using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentDemo.Models
{

  public class Trip
  {

    public string Destination { get; set; }

  }

  public class TripRepository
  {

    private static readonly Trip[] _Trips = new Trip[]
    {
      new Trip {Destination="Seattle" },
      new Trip {Destination="Philadelphia" },
      new Trip {Destination="Las Vegas" },
      new Trip {Destination="Cleveland" },
      new Trip {Destination="Chicago" }
    };

    public IEnumerable<Trip> Get()
    {
      return _Trips;
    }
  }

}
