// This file demonstrates the concept: Methods in C#
namespace Topics.Methods_Parameters
{
    public class Methods
    {
        // A simple method that adds two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // A method with no return value
        public void PrintMessage(string message)
        {
            System.Console.WriteLine($"Message: {message}");
        }

        // A method with a default parameter
        public int Multiply(int a, int b = 2)
        {
            return a * b;
        }
    }
}
