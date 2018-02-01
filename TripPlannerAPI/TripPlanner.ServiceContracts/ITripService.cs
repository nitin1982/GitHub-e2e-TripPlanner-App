using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface ITripService
    {
        IQueryable<Trip> GetAllTrips();
        IQueryable<Trip> GetAllUpcoming();
        IQueryable<Trip> GetAllPastTrips();
        Task<Trip> GetTripByID(int tripID);
        Task<int> AddTrip(Trip trip);
        Task<bool> UpdateTrip(Trip trip);
        Task<bool> DeleteTrip(int tripID);
    }
}
