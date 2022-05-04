using Microsoft.AspNetCore.Mvc;
using PracticeApiNet5.Entities;
using PracticeApiNet5.Methods;
using PracticeApiNet5.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 


namespace PracticeApiNet5.Controllers 
{
    [Route("api/[controller]")] 
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository; 

        public PostsController(IPostRepository postService)
        {
            _postRepository = postService; //przepisujesz posty
        }


        [SwaggerOperation(Summary = "Retrieves all posts")]
        [HttpGet] // api/posts
        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _postRepository.GetAllAsync();
        }


        [SwaggerOperation(Summary = "Retrieves post by Id")]
        [HttpGet("{id}")] // api/posts/id
        public async Task<IActionResult> Get(int id)
        {
            var post = await _postRepository.GetByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

    }
}
