using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.LocationRepository;

namespace Showcase.API.Controllers
{
    public class LocationController : BaseController<Location>
    {
        public LocationController(ILocationRepository locationRepository) : base(locationRepository)
        {
        }

        protected override int GetEntityId(Location entity)
        {
            return entity.Id;
        }
    }
}
