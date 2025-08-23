using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.PerformanceRepository
{
	public class PerformanceRepository : BaseRepository<Performance>, IPerformanceRepository
	{
		public PerformanceRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}