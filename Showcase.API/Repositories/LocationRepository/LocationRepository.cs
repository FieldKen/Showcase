using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.LocationRepository
{
	public class LocationRepository : BaseRepository<Location>, ILocationRepository
	{
		public LocationRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}