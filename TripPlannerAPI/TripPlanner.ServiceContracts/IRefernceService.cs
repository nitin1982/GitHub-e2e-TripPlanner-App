using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface IRefernceService
    {
        Task<Reference> GetReferenceByCategory(string refCatCode);
        Task<Reference> GetReferenceByRefenceCode(string refCode);
    }
}
