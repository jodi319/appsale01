using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using myshoppe_demoService.DataObjects;
using myshoppe_demoService.Models;

namespace myshoppe_demoService.Controllers
{
    public class RegionController : TableController<Region>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myshoppe_demoContext context = new myshoppe_demoContext();
            DomainManager = new EntityDomainManager<Region>(context, Request);
        }

        // GET tables/Region
        public IQueryable<Region> GetAllRegion()
        {
            return Query(); 
        }

        // GET tables/Region/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Region> GetRegion(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Region/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Region> PatchRegion(string id, Delta<Region> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Region
        public async Task<IHttpActionResult> PostRegion(Region item)
        {
            Region current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Region/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteRegion(string id)
        {
             return DeleteAsync(id);
        }
    }
}
