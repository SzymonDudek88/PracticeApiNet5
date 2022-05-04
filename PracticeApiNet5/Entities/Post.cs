using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApiNet5.Entities
{
    public class Post
    {
        
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        public Post(int userId , int id, string title, bool complete)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Completed = complete;

        }
       
    }
}
