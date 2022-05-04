using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeApiNet5.Entities; 
using System.Threading;
 

namespace PracticeApiNet5.Repositories
{
    public class PostRepository : IPostRepository
    {
        private static readonly ISet<Post> _posts = new HashSet<Post>()
        {
         new Post  (0, 0 , "Title1", true),
         new Post  (1, 1 , "Title1", true),
         new Post  (2, 2 , "Title1", true)
        };

        public IEnumerable<Post>  GetAll() // This function is going to be async in future
        { 
            return _posts;
        }

        public  Post GetById(int id)
        {
            return _posts.SingleOrDefault(x => x.Id == id);

        }


    }
}
