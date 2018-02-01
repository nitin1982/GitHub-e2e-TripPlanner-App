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
    public class PictureService : IPictureService
    {
        private ITripPlannerUoW _uow;

        public PictureService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }
        
        public async Task<bool> DeletePicture(int pictureID)
        {
            bool result = false;
            try
            {
                this._uow.PictureRepository.DeleteRange(pic => pic.ID == pictureID);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public async Task<IEnumerable<Picture>> GetAllPictureByTripID(int tripID)
        {
            IEnumerable<Picture> pictures = default(IEnumerable<Picture>);
            try
            {
                pictures = await this._uow.PictureRepository.GetFilteredAsync(pic => pic.TripID == tripID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pictures;
        }

        public async Task<Picture> GetPictureByID(int pictureID)
        {
            try
            {
                return await this._uow.PictureRepository.GetByIDAsync(pictureID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
