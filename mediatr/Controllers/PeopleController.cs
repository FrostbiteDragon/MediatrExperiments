using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Controllers
{
    [ApiController]
    [Route("people")]
    public class PeopleController : Controller
    {
        readonly IMediator _mediator;

        public PeopleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> Index()
        {
            return await _mediator.Send(new GetAllPeopleQuerry());
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] AddPersonCommand command)
        {
            _mediator.Send(command);
            return Ok("person Created");
        }
    }
}
