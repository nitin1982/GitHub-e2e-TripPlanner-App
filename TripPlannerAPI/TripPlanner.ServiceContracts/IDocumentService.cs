using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.ServiceContracts
{
    public interface IDocumentService
    {
        Task<Document> GetDocumentByID(int documentID);
        Task<IEnumerable<Document>> GetAllDocumentByTripID(int tripID);
        Task<bool> DeleteDocument(int documentID);
    }
}
