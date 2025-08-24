using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.FestivalRepository;

namespace Showcase.API.Controllers
{
    public class FestivalController : BaseController<Festival>
    {
        public FestivalController(IFestivalRepository festivalRepository) : base(festivalRepository)
        {
        }

        protected override int GetEntityId(Festival entity)
        {
            return entity.Id;
        }
    }
}
