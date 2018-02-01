using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.RepositoriesUoW
{
    public class TripPlannerUoW : IDisposable, ITripPlannerUoW
    {
        private bool _disposed;
        private TripPlannerEntities _dbContext;
        private TripPlannerRepository<Document> _documentRepository;
        private TripPlannerRepository<Picture> _pictureRepository;
        private TripPlannerRepository<Reference> _referenceRepository;
        private TripPlannerRepository<ReferenceCategory> _referenceCategoryRepository;
        private TripPlannerRepository<Trip> _tripRepository;
        private TripPlannerRepository<TripImportantDate> _tripImportantDateRepository;
        private TripPlannerRepository<WebLink> _weblinkRepository;


        public TripPlannerUoW(TripPlannerEntities context)
        {
            _dbContext = context;
        }

        ~TripPlannerUoW()
        {
            Disposing(false);
        }

        public TripPlannerRepository<Document> DocumentRepository
        {
            get
            {
                if (this._documentRepository == null)
                {
                    this._documentRepository = new TripPlannerRepository<Document>(this._dbContext);
                }

                return this._documentRepository;
            }
        }

        public TripPlannerRepository<Picture> PictureRepository
        {
            get
            {
                if (this._pictureRepository == null)
                {
                    this._pictureRepository = new TripPlannerRepository<Picture>(this._dbContext);
                }

                return this._pictureRepository;
            }
        }

        public TripPlannerRepository<Reference> ReferenceRepository
        {
            get
            {
                if (this._referenceRepository == null)
                {
                    this._referenceRepository = new TripPlannerRepository<Reference>(this._dbContext);
                }

                return this._referenceRepository;
            }
        }

        public TripPlannerRepository<ReferenceCategory> ReferenceCategoryRepository
        {
            get
            {
                if (this._referenceCategoryRepository == null)
                {
                    this._referenceCategoryRepository = new TripPlannerRepository<ReferenceCategory>(this._dbContext);
                }

                return this._referenceCategoryRepository;
            }
        }

        public TripPlannerRepository<Trip> TripRepository
        {
            get
            {
                if (this._tripRepository == null)
                {
                    this._tripRepository = new TripPlannerRepository<Trip>(this._dbContext);
                }

                return this._tripRepository;
            }
        }

        public TripPlannerRepository<TripImportantDate> TripImportantDateRepository
        {
            get
            {
                if (this._tripImportantDateRepository == null)
                {
                    this._tripImportantDateRepository = new TripPlannerRepository<TripImportantDate>(this._dbContext);
                }

                return this._tripImportantDateRepository;
            }
        }

        public TripPlannerRepository<WebLink> WeblinkRepository
        {
            get
            {
                if (this._weblinkRepository == null)
                {
                    this._weblinkRepository = new TripPlannerRepository<WebLink>(this._dbContext);
                }

                return this._weblinkRepository;
            }
        }

        protected virtual void Disposing(bool disposing)
        {
            if (disposing)
            {
                if (!_disposed)
                {
                    _dbContext.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Disposing(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
