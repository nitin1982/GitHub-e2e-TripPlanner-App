using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface ITripImportantDatesService
    {
        Task<TripImportantDate> GetTripImportantDateByID(int tripImpDateID);
        Task<IEnumerable<TripImportantDate>> GetAllImportantDatesID(int tripID);
        Task<bool> DeleteTripImportantDate(int tripImpDateID);
        Task<bool> UpdateTripImportantDate(TripImportantDate tripImpDate);
        Task<IEnumerable<TripImportantDate>> GetImportantDatesReminderForComingDays(DateTime fromDate);
    }
}
