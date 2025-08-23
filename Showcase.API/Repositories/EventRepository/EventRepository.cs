using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.EventRepository
{
	public class EventRepository : BaseRepository<Event>, IEventRepository
	{
		public EventRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}