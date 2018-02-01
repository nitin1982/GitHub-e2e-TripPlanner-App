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
    public class DocumentService : IDocumentService
    {
        private ITripPlannerUoW _uow;

        public DocumentService(ITripPlannerUoW uow)
        {
            this._uow = uow;
        }

        public async Task<bool> DeleteDocument(int documentID)
        {
            bool result = false;
            try
            {
                this._uow.DocumentRepository.DeleteRange(doc => doc.ID == documentID);
                await this._uow.SaveAsync();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<IEnumerable<Document>> GetAllDocumentByTripID(int tripID)
        {
            IEnumerable<Document> documents = default(IEnumerable<Document>);
            try
            {
                documents = await this._uow.DocumentRepository.GetFilteredAsync(doc => doc.TripID == tripID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return documents;
        }

        public async Task<Document> GetDocumentByID(int documentID)
        {
            try
            {
                return await this._uow.DocumentRepository.GetByIDAsync(documentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
