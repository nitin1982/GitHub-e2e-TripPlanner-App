using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner.DAL
{
    public class TripPlannerContextFactory : IDbContextFactory<TripPlannerEntities>
    {
        public TripPlannerEntities Create()
        {
            return new TripPlannerEntities(@"data source=(localdb)\MSSQLLocalDB;initial catalog=TripPlannerDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
