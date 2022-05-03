using System.Threading.Tasks;

namespace PracticeApiNet5.Methods
{
    public class StatusMethods
    {
        public static async Task<bool> IsRunning()
        {
            // I guess it is totally unnecessary but I wanted to remove compiler green annotation
            // so I created await true/false in BoolExtensions.cs and it works :D
            return await true; 
        }
    }
}
