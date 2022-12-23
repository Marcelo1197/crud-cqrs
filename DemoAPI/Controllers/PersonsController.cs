using DemoLibrary.Commands;
using DemoLibrary.DTOs;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IMediator _mediator; 
        public PersonsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonsController>
        [HttpGet]
        public async Task<List<PersonDTO>> GetPersons()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(int id)
        {
            return await _mediator.Send(new GetPersonQuery(id));
        }

        // POST api/<PersonsController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PersonDTO person)
        {
            _mediator.Send(new AddPersonCommand { Name = person.Name, LastName = person.LastName});

            return NoContent();
        }
    }
}
