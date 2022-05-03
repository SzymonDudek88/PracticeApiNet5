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
        private readonly DataMethods _data;

        public StatusController(DataMethods data)
        {
            _data = data;
        }

        [SwaggerOperation(Summary = "Check status of application")]
        [HttpGet] //("[action]") - for /api/Status/GetStatus
        public IActionResult GetStatus()
        { 
            return Ok();
        }

        [SwaggerOperation(Summary = "Check status of application using external method")]
        [HttpGet("[action]")] // - for /api/Status/GetStatus
        public async ValueTask<IActionResult> GetStatusByExternalMethod()
        {
            var state = await StatusMethods.IsRunningAsync();

            return Ok(state);
        }
        [SwaggerOperation( Summary = "Get Data" ,  Description= "First use - gets fresh data, second use - gets data from cache"    )]
        [HttpGet("[action]")] // - for /api/Status/GetStatus
        public async ValueTask<IActionResult> GetData()
        {
          var data =  await _data.GetData();

            return Ok(data );
        }
    }
}
