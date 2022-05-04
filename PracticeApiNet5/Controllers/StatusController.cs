using Microsoft.AspNetCore.Mvc;
using PracticeApiNet5.Methods;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
 


namespace PracticeApiNet5.Controllers 
{
    [Route("api/[controller]")] 
    [ApiController]
    public class StatusController : ControllerBase
    { 
         

        [SwaggerOperation(Summary = "Check status of application")]
        [HttpGet] //("[action]") - for /api/Status/GetStatus
        public IActionResult GetStatus()
        { 
            return Ok();
        }

       
      
    }
}
