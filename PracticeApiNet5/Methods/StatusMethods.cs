using System.Threading.Tasks;
using PracticeApiNet5.Methods; // This let me use BoolExtensions.cs

namespace PracticeApiNet5.Methods // This too
{
    public class StatusMethods
    {
        public static async Task<bool> IsRunning()
        {
            // I guess it is totally unnecessary but I wanted to remove compiler green annotation
            // so I created await true/false in BoolExtensions.cs and it works :D
            // https://tooslowexception.com/await-false-await-true/
            return await true; 
        }

        public static async Task<int> GetAwaitInt()
        {
            int test =   123;

            return  await test; // lol
        }
    }
}
