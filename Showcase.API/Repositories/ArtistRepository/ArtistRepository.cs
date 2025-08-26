using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.ArtistRepository
{
	public class IUserRepository : BaseRepository<Artist>, IArtistRepository
	{
		public IUserRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}