using Microsoft.AspNetCore.Mvc;
using Showcase.API.Domain;
using Showcase.API.Repositories.ConcertRepository;
using Showcase.API.Repositories.UserConcertRepository;
using Showcase.API.Repositories.UserRepository;

namespace Showcase.API.Controllers
{
    public class UserConcertController : BaseController<UserConcert>
    {
        public UserConcertController(IUserConcertRepository userConcertRepository) : base(userConcertRepository)
        {
        }

        protected override int GetEntityId(UserConcert entity)
        {
            return entity.Id;
        }
    }
}
