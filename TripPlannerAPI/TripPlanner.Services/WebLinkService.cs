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
    public class WebLinkService : IWebLinkService
    {
        private ITripPlannerUoW _uow;

        public WebLinkService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }

        public async Task<bool> DeleteWebLink(int weblinkID)
        {
            bool result = false;
            try
            {
                this._uow.WeblinkRepository.DeleteRange(wbLnk => wbLnk.ID == weblinkID);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<IEnumerable<WebLink>> GetAllWebLinksByTripID(int tripID)
        {
            IEnumerable<WebLink> weblinks = default(IEnumerable<WebLink>);
            try
            {
                weblinks = await this._uow.WeblinkRepository.GetFilteredAsync(wbLnk => wbLnk.TripID == tripID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return weblinks;
        }

        public async Task<WebLink> GetWebLinkByID(int weblinkID)
        {
            try
            {
                return await this._uow.WeblinkRepository.GetByIDAsync(weblinkID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateWebLink(WebLink weblink)
        {
            bool result = false;
            try
            {
                this._uow.WeblinkRepository.Update(weblink);
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
