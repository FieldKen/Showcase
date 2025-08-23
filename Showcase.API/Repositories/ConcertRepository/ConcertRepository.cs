using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.ConcertRepository
{
	public class ConcertRepository : BaseRepository<Concert>, IConcertRepository
	{
		public ConcertRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}