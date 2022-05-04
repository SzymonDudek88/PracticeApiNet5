using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApiNet5.Methods
{
    public interface IDataMethods
    {
        public ValueTask<List<int>> GetData();
    }
}
