using System.Collections.Generic;
using System.Linq;

namespace Trips.Data
{
    class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }

        public void Deletetrip(int tripId)
        {
            var OldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (OldTrip != null)
            {
                Data.Trips.Remove(OldTrip);
            }
        }

        public List<Trip> GetAllTrips()
        {
            return Data.Trips.ToList();
        }

        public Trip GetTripById(int tripId)
        {
            return Data.Trips.FirstOrDefault(n => n.Id == tripId);
        }

        public void Updatetrip(int tripId, Trip trip)
        {
            var OldTrip = Data.Trips.FirstOrDefault(n => n.Id == trip.Id);
            if (OldTrip != null)
            {
                OldTrip.Name            = trip.Name;
                OldTrip.Description     = trip.Description;
                OldTrip.DateStarted     = trip.DateStarted;
                OldTrip.DateCompleted   = trip.DateCompleted;
            }
        }
    }
}