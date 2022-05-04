using Microsoft.AspNetCore.Mvc;
using PracticeApiNet5.Methods;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
 


namespace PracticeApiNet5.Controllers 
{
    [Route("api/[controller]")] 
    [ApiController]
    public class TestController : ControllerBase
    { 
        private readonly DataMethods _data;

        public TestController(DataMethods data)
        {
            _data = data;
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
