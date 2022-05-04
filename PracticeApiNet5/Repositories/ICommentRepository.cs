using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeApiNet5.Entities;

namespace PracticeApiNet5.Repositories
{
    public interface ICommentRepository
    {
       Task<IEnumerable<Comment>> GetAllAsync();

        Task<Comment> GetByIdAsync(int id);

    }
}
