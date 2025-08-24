using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.PerformanceRepository;

namespace Showcase.API.Controllers
{
    public class PerformanceController : BaseController<Performance>
    {
        public PerformanceController(IPerformanceRepository performanceRepository) : base(performanceRepository)
        {
        }

        protected override int GetEntityId(Performance entity)
        {
            return entity.Id;
        }
    }
}
