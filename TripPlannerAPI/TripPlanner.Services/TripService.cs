using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;
using TripPlanner.RepositoriesUoW;
using TripPlanner.ServiceContracts;

namespace TripPlanner.Services
{
    public class TripService : ITripService
    {
        private ITripPlannerUoW _uow;

        public TripService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }

        public async Task<int> AddTrip(Trip trip)
        {
            int result = 0;
            try
            {
                this._uow.TripRepository.Add(trip);
                result = await this._uow.SaveAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<bool> DeleteTrip(int tripID)
        {
            bool result = false;
            try
            {
                this._uow.TripRepository.DeleteRange(trip => trip.ID == tripID);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public IQueryable<Trip> GetAllPastTrips()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Trip> GetAllTrips()
        {
            IQueryable<Trip> allTrips = default(IQueryable<Trip>);
            try
            {
                allTrips = this._uow.TripRepository.GetQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allTrips;
        }

        public IQueryable<Trip> GetAllUpcoming()
        {
            IQueryable<Trip> allTrips = default(IQueryable<Trip>);
            try
            {
                allTrips = this._uow.TripRepository.GetQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allTrips;
        }

        public async Task<Trip> GetTripByID(int tripID)
        {
            try
            {
                return await this._uow.TripRepository.GetByIDAsync(tripID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateTrip(Trip trip)
        {
            bool result = false;
            try
            {
                this._uow.TripRepository.Update(trip);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }
    }
}
