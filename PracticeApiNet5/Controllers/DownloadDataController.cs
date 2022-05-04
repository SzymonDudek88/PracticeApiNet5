using Microsoft.AspNetCore.Mvc;
using PracticeApiNet5.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;


namespace PracticeApiNet5.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class DownloadDataController : ControllerBase
    {
        

        [SwaggerOperation(Summary = "Download data from jsonplaceholder")]
        [HttpGet] // api/posts
        public List<string> GetAllPosts()
        {
            var client = new WebClient();
           List<string> posts = new List<string>();   

            for (int i = 1; i < 5; i++)
            {
                var text = client.DownloadString($"http://jsonplaceholder.typicode.com/posts/{i}");
                posts.Add(text);    
            }

            return posts;
        }



    }
}
