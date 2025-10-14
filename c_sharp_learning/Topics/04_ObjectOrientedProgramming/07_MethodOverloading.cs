// This file demonstrates the concept: Method Overloading
namespace Topics.ObjectOrientedProgramming
{
    public class MethodOverloading
    {
        // 🔹 Method overloading means defining multiple methods
        // with the SAME NAME but DIFFERENT parameter lists
        // (different number, type, or order of parameters).

        // 1️⃣ Overload #1 — takes two integers
        public void PrintSum(int a, int b)
        {
            System.Console.WriteLine($"Sum of two integers: {a + b}");
        }

        // 2️⃣ Overload #2 — takes three integers
        public void PrintSum(int a, int b, int c)
        {
            System.Console.WriteLine($"Sum of three integers: {a + b + c}");
        }

        // 3️⃣ Overload #3 — takes two doubles (different data type)
        public void PrintSum(double a, double b)
        {
            System.Console.WriteLine($"Sum of two doubles: {a + b}");
        }

        // 4️⃣ Overload #4 — takes a string and an int (different parameter order/types)
        public void PrintSum(string message, int value)
        {
            System.Console.WriteLine($"{message}: {value}");
        }

        // 🔹 DEMO method to show how overloads are chosen
        public void Demo()
        {
            // Compiler decides which method to call
            // based on the argument types and number of parameters

            PrintSum(5, 10);             // Calls overload #1 → "Sum of two integers: 15"
            PrintSum(5, 10, 15);         // Calls overload #2 → "Sum of three integers: 30"
            PrintSum(2.5, 3.7);          // Calls overload #3 → "Sum of two doubles: 6.2"
            PrintSum("The total is", 100); // Calls overload #4 → "The total is: 100"
        }
    }

    // 🔹 Optional: Entry point to run the demo
    public class Program4
    {
        public static void Main4()
        {
            MethodOverloading demo = new MethodOverloading();
            demo.Demo();
        }
    }
}
