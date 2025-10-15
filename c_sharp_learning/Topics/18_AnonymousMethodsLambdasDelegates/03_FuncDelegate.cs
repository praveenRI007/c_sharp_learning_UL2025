// This file demonstrates the concept: Func delegate in C#
namespace Topics.AnonymousMethodsLambdasDelegates
{
    public class FuncDelegate
    {
        public void Demo()
        {
            // Func delegate: takes parameters and returns a value
            System.Func<int, int, int> multiply = (x, y) => x * y;
            int result = multiply(4, 5);
            System.Console.WriteLine($"4 * 5 = {result}"); // Output: 4 * 5 = 20
        }
    }
}
