using System;
using System.Runtime.CompilerServices;

namespace PracticeApiNet5.Methods
{

    internal static class BoolExtensions
    {
        public static BoolAwaiter GetAwaiter(this bool value) => new BoolAwaiter(value);
    }
     
    internal class BoolAwaiter : INotifyCompletion
    {
        private readonly bool _value;
        public BoolAwaiter(bool value) => _value = value;

        public bool IsCompleted => true;
        public void OnCompleted(Action continuation) { } // Never called
        public bool GetResult() => _value;
    }
}
 
