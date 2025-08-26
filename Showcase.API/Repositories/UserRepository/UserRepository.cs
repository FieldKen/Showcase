using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.UserRepository
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}