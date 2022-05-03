using System;
using System.Runtime.CompilerServices;

namespace PracticeApiNet5.Methods
{
    // https://tooslowexception.com/await-false-await-true/
    internal static class BoolExtensions
    {
        public static BoolAwaiter GetAwaiter(this bool value) => new BoolAwaiter(value);
        public static IntAwaiter GetAwaiter(this int value) => new IntAwaiter(value);
    }
     
    //I am not quite sure what is going on here
    internal class BoolAwaiter : INotifyCompletion
    {
        private readonly bool _value;
        public BoolAwaiter(bool value) => _value = value;

        public bool IsCompleted => true;
        public void OnCompleted(Action continuation) { } // Never called
        public bool GetResult() => _value;
    }
    internal class IntAwaiter : INotifyCompletion
    {
        private readonly int _value;
        public IntAwaiter(int value) => _value = value;

        public bool IsCompleted => true;
        public void OnCompleted(Action continuation) { } // Never called
        public int GetResult() => _value;
    }
}
 
