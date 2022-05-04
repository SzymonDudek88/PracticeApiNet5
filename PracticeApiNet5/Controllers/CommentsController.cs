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
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository; 

        public CommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository; //przepisujesz posty
        }


        [SwaggerOperation(Summary = "Retrieves all comments")]
        [HttpGet] // /api/comments 
        public IEnumerable<Comment > GetAll()
        {
            return _commentRepository.GetAll();
        }


        [SwaggerOperation(Summary = "Retrieves comment by Id")]
        [HttpGet("{id}")] // /api/comments/id
        public IActionResult Get(int id)
        {
            var comment = _commentRepository.GetById(id);
            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

    }
}
