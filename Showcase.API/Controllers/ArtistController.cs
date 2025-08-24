using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.ArtistRepository;

namespace Showcase.API.Controllers
{
    public class ArtistController : BaseController<Artist>
    {
        public ArtistController(IArtistRepository artistRepository) : base(artistRepository)
        {
        }

        protected override int GetEntityId(Artist entity)
        {
            return entity.Id;
        }
    }
}
