// This file demonstrates the concept: Lambda expressions in C#
namespace Topics.AnonymousMethodsLambdasDelegates
{
    public class LambdaExpressions
    {
        public void Demo()
        {
            // Lambda expression assigned to a delegate
            System.Action greet = () => System.Console.WriteLine("Hello from lambda expression!");
            greet(); // Output: Hello from lambda expression!

            // Lambda with parameters
            System.Func<int, int, int> add = (a, b) => a + b;
            System.Console.WriteLine(add(2, 3)); // Output: 5
        }
    }
}
