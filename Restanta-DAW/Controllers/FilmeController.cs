using Microsoft.AspNetCore.Mvc;
using Restanta_DAW.Models.Domain;
using Restanta_DAW.Repositories.Implementation;
using Restanta_DAW.Repositories.Interface;

namespace Restanta_DAW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly IRepository<Actor> _filmeRepository;

        public FilmeController(IRepository<Actor> actorRepository)
        {
            _filmeRepository = actorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_filmeRepository.GetAll());
        }
    }

}
