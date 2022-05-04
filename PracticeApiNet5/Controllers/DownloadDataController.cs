using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracticeApiNet5.Entities;
using PracticeApiNet5.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;


namespace PracticeApiNet5.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class DownloadDataController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public DownloadDataController(IPostRepository postService)
        {
            _postRepository = postService; //przepisujesz posty
        }

        [SwaggerOperation(Summary = "Download data from jsonplaceholder")]
        [HttpGet] // api/posts
        public List<Post> GetAllPosts()
        {
           var client = new WebClient();
           List<Post> posts = new List<Post>();   

            for (int i = 1; i < 5; i++)
            {
                var text = client.DownloadString($"http://jsonplaceholder.typicode.com/posts/{i}");
                Post post = JsonConvert.DeserializeObject<Post>(text);
                posts.Add(post);
                _postRepository.AddPost(post);
            }

            
            return posts;
        }



    }
}
