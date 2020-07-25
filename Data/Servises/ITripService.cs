using System.Collections.Generic;

namespace Trips.Data
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void Updatetrip(int tripId, Trip trip);
        void Deletetrip(int tripId);
        void AddTrip(Trip trip);
    }
}