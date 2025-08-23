using Showcase.API.Domain;
using Showcase.API.Database;
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Repositories.ArtistRepository
{
	public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
	{
		public ArtistRepository(ShowcaseDbContext context) : base(context)
		{
		}
	}
}