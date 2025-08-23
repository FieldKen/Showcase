using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.FestivalRepository
{
	public class FestivalRepository : BaseRepository<Festival>, IFestivalRepository
	{
		public FestivalRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}