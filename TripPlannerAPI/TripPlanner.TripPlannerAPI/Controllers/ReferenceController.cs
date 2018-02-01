using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.DAL;
using TripPlanner.RepositoriesUoW;
using TripPlanner.Services;

namespace TripPlanner.TripPlannerAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Reference")]
    public class ReferenceController : Controller
    {
        private ReferenceService _refService;
        
        public ReferenceController(ReferenceService service)
        {
            _refService = service;
        }
        public IEnumerable<ReferenceCategory> GetAllReferenceCategories()
        {
            try
            {

                IEnumerable<ReferenceCategory> refData = null;
                refData = this._refService.GetAllReferenceCategories();
                List<ReferenceCategory> data = refData.ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}