using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //should mean if we go to api/activities we should hit the endpoint of the activities controller.
    public class BaseApiController : ControllerBase
    {
        
    }
}