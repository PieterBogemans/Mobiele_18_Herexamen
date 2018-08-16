using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TripRepository : MonoBehaviour
{

    public int IdCount { get; set; }
    public Dictionary<int, Trip> Trips { get; set; }


    public void AddTrip(string name, Currency defaultCurrency)
    {
        Trip trip = new Trip(name, IdCount, defaultCurrency);
        IdCount++;
        Trips.Add(trip.Id, trip);
    }

    public Trip GetTrip(int id)
    {
        return Trips[id];
    }

    public Trip GetTrip(string name)
    {
        foreach (Trip trip in Trips.Values)
        {
            if (trip.LocationName.Equals(name))
            {
                return trip;
            }
        }
        throw new System.Exception("Name not in repo");
    }

    void Start()
    {
        IdCount = 0;
        Trips = new Dictionary<int, Trip>();
    }
}
