using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //should mean if we go to api/activities we should hit the endpoint of the activities controller.
    public class BaseApiController : ControllerBase
    {
        //Make MediatR accessible be default for all API controllers.
        private IMediator _mediator;

        //Null colessing assignemnt operator.  If _mediator is NULL then we are going to assign to this property whatever is to the right of it.
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();
    }
}