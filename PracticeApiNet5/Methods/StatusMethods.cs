using System.Threading.Tasks;

namespace PracticeApiNet5.Methods  
{
    public class StatusMethods
    {
        public static async ValueTask<bool> IsRunningAsync()
        { 
            await Task.Delay(1);  // There is nothing async to do
            return true; 
        }
       
    }
}
