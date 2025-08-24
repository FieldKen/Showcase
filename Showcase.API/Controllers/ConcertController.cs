using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.ConcertRepository;

namespace Showcase.API.Controllers
{
    public class ConcertController : BaseController<Concert>
    {
        public ConcertController(IConcertRepository concertRepository) : base(concertRepository)
        {
        }

        protected override int GetEntityId(Concert entity)
        {
            return entity.Id;
        }
    }
}
