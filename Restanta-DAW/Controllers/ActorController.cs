using Microsoft.AspNetCore.Mvc;
using Restanta_DAW.Models.Domain;
using Restanta_DAW.Repositories.Implementation;

namespace Restanta_DAW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IRepository<Actor> _actorRepository;

        public ActorController(IRepository<Actor> actorRepository)
        {
            _actorRepository = actorRepository;
        }

        [HttpGet]
        [HttpPost]
        public async Task<ActionResult<Actor>> PostActor([FromBody] Actor actor)
        {
            await _actorRepository.AddActorAsync(actor);
            return CreatedAtAction("GetActor", new { id = actor.ActorId }, actor);
        }
    }




}
