using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.DAL;

namespace TripPlanner.RepositoriesUoW
{
    /// <summary>
    /// Generic Repository Class for Trip Planner Project.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class TripPlannerRepository<TEntity> : ITripPlannerRepository<TEntity> where TEntity : BaseEntity
    {
        private TripPlannerEntities _dbContext;
        private DbSet<TEntity> _dbSet;

        public TripPlannerRepository(TripPlannerEntities context)
        {
            this._dbContext = context;
            this._dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var result = _dbSet.AsEnumerable();
            return result;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity GetByID(int id)
        {
            return _dbSet.SingleOrDefault(en => en.ID == id);
        }

        public async Task<TEntity> GetByIDAsync(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(en => en.ID == id);
        }

        public IEnumerable<TEntity> GetFiltered(Func<TEntity, bool> where)
        {
            return _dbSet.Where(where).AsEnumerable();
        }

        public async Task<IEnumerable<TEntity>> GetFilteredAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            return await _dbSet.Where(where).ToListAsync();
        }

        public void Add(TEntity entity)
        {
            this._dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public void DeleteRange(Func<TEntity, bool> where)
        {
            var entitiesToDelete = _dbSet.Where(where);
            _dbSet.RemoveRange(entitiesToDelete);
        }

        public IQueryable<TEntity> GetWithInclude(System.Linq.Expressions.Expression<Func<TEntity, bool>> where, params string[] include)
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(where);
        }

        public TEntity GetFirst(Func<TEntity, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public async Task<TEntity> GetFirstAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            return await _dbSet.FirstOrDefaultAsync(where);
        }

        public TEntity GetSingle(Func<TEntity, bool> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public async Task<TEntity> GetSingleAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> where)
        {
            return await _dbSet.SingleOrDefaultAsync(where);
        }
    }
}
