using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeApiNet5.Entities;

namespace PracticeApiNet5.Repositories
{
    public class CommentRepository
    {


        private static readonly ISet<Comment> _orders = new HashSet<Comment>()
        {
         new Comment  (0,0,"John", "John@pl.pl","Usun konto"),
         new Comment  (1,1,"John2", "John2@pl.pl","Usun konto"),
         new Comment  (2,2,"John3", "John3@pl.pl","Usun konto")
        };
    }
}
