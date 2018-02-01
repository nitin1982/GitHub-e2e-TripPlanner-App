using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface IWebLinkService
    {
        Task<WebLink> GetWebLinkByID(int weblinkID);
        Task<IEnumerable<WebLink>> GetAllWebLinksByTripID(int tripID);
        Task<bool> DeleteWebLink(int weblinkID);
        Task<bool> UpdateWebLink(WebLink weblink);
    }
}
