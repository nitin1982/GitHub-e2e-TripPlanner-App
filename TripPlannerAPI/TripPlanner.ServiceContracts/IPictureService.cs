using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface IPictureService
    {
        Task<Picture> GetPictureByID(int pictureID);
        Task<IEnumerable<Picture>> GetAllPictureByTripID(int tripID);
        Task<bool> DeletePicture(int pictureID);
    }
}
