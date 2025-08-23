using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.VenueRepository
{
	public class VenueRepository : BaseRepository<Venue>, IVenueRepository
	{
		public VenueRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}