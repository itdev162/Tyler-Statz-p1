  
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Posts;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketballController : ControllerBase
    {
        private readonly IMediator mediator;
        public BasketballController(IMediator mediator) => this.mediator = mediator; 

        public async Task<ActionResult<List<Post>>> List() 
        {
            return await this.mediator.Send(new List.Query());
        }
    }
}
   