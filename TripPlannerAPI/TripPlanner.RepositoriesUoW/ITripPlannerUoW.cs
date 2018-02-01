using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.RepositoriesUoW
{
    public interface ITripPlannerUoW
    {
        TripPlannerRepository<Document> DocumentRepository { get; }
        TripPlannerRepository<Picture> PictureRepository { get; }
        TripPlannerRepository<ReferenceCategory> ReferenceCategoryRepository { get; }
        TripPlannerRepository<Reference> ReferenceRepository { get; }
        TripPlannerRepository<TripImportantDate> TripImportantDateRepository { get; }
        TripPlannerRepository<Trip> TripRepository { get; }
        TripPlannerRepository<WebLink> WeblinkRepository { get; }

        int Save();
        Task<int> SaveAsync();
    }
}