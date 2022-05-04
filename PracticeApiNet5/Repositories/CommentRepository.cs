using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeApiNet5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace PracticeApiNet5.Repositories
{
    public class CommentRepository : ICommentRepository
    {


        private static readonly ISet<Comment> _comments = new HashSet<Comment>()
        {
         new Comment  (0,0,"John", "John@pl.pl","Usun konto"),
         new Comment  (1,1,"John2", "John2@pl.pl","Usun konto"),
         new Comment  (2,2,"John3", "John3@pl.pl","Usun konto")
        };

        public  IEnumerable<Comment> GetAll()
        {
            return _comments;
        }

        public Comment GetById(int id)
        {
            return   _comments.SingleOrDefault(x => x.Id == id);
   
        }
    }
}
