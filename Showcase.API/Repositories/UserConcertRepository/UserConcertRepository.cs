using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.UserConcertRepository
{
	public class UserConcertRepository : BaseRepository<UserConcert>, IUserConcertRepository
	{
		public UserConcertRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}