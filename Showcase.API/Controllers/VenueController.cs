using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.VenueRepository;

namespace Showcase.API.Controllers
{
    public class VenueController : BaseController<Venue>
    {
        public VenueController(IVenueRepository venueRepository) : base(venueRepository)
        {
        }

        protected override int GetEntityId(Venue entity)
        {
            return entity.Id;
        }
    }
}
