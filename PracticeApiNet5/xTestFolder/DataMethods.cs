using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace PracticeApiNet5.Methods
{
    public class DataMethods : IDataMethods
    {
        private readonly IMemoryCache _memoryCache;
        public DataMethods(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public   async ValueTask<List<int>> GetData()
        {
            //
            var output = _memoryCache.Get<List<int>>("numbers");
            Random rnd = new Random();
            var listOfInts = new List<int>();

            if (output == null)
            {
                for (int i = 0; i < 3; i++)
                {
                    await Task.Delay(1000);
                    listOfInts.Add(rnd.Next(0, 11));
                }
            }
            _memoryCache.Set("numbers", output, TimeSpan.FromMinutes(1));

            return output; 
        }
    }
}
