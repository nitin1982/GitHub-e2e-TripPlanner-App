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
    public class TripImportantDatesService : ITripImportantDatesService
    {
        private ITripPlannerUoW _uow;

        public TripImportantDatesService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }

        public async Task<bool> DeleteTripImportantDate(int tripImpDateID)
        {
            bool result = false;
            try
            {
                this._uow.TripImportantDateRepository.DeleteRange(impDt => impDt.ID == tripImpDateID);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public async Task<IEnumerable<TripImportantDate>> GetAllImportantDatesID(int tripID)
        {
            IEnumerable<TripImportantDate> impDates = default(IEnumerable<TripImportantDate>);
            try
            {
                impDates = await this._uow.TripImportantDateRepository.GetFilteredAsync(impDt => impDt.TripID == tripID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return impDates;
        }

        public async Task<IEnumerable<TripImportantDate>> GetImportantDatesReminderForComingDays(DateTime fromDate)
        {
            IEnumerable<TripImportantDate> impDates = default(IEnumerable<TripImportantDate>);
            try
            {
                impDates = await this._uow.TripImportantDateRepository.GetFilteredAsync(impDt => impDt.ImpDate.HasValue && impDt.ImpDate.Value >= fromDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return impDates;
        }

        public async Task<TripImportantDate> GetTripImportantDateByID(int tripImpDateID)
        {
            try
            {
                return await this._uow.TripImportantDateRepository.GetByIDAsync(tripImpDateID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateTripImportantDate(TripImportantDate tripImpDate)
        {
            bool result = false;
            try
            {
                this._uow.TripImportantDateRepository.Update (tripImpDate);
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
