using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.EventRepository;

namespace Showcase.API.Controllers
{
    public class EventController : BaseController<Event>
    {
        public EventController(IEventRepository eventRepository) : base(eventRepository)
        {
        }

        protected override int GetEntityId(Event entity)
        {
            return entity.Id;
        }
    }
}
