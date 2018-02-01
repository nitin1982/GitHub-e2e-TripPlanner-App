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
    public class ReferenceService: IRefernceService
    {
        private ITripPlannerUoW _uow;

        public ReferenceService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }

        //TODO: Delete below test method.
        public IEnumerable<ReferenceCategory> GetAllReferenceCategories()
        {
            return this._uow.ReferenceCategoryRepository.GetAll();
        }

        public Task<Reference> GetReferenceByCategory(string refCatCode)
        {
            throw new NotImplementedException();
        }

        public Task<Reference> GetReferenceByRefenceCode(string refCode)
        {
            throw new NotImplementedException();
        }
    }
}
