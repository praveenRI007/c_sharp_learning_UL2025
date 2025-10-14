// This file demonstrates the concept: Method parameters
// Namespace organizes code logically (like a folder)
namespace Topics.Methods_Parameters
{
    public class MethodParameters
    {
        // 1️⃣ Passing parameters by VALUE
        // When passed by value, the method gets a COPY of the argument.
        // Any change inside this method DOES NOT affect the original variable.
        public void PrintSum(int a, int b)
        {
            System.Console.WriteLine($"Sum: {a + b}");
        }

        // 2️⃣ Passing parameters by REFERENCE using 'ref'
        // When passed by reference, the method gets a REFERENCE (not a copy)
        // So changes inside the method affect the original variable.
        public void Increment(ref int number)
        {
            number++;
        }

        // 3️⃣ Using OUT parameters
        // 'out' parameters allow a method to RETURN multiple values.
        // You MUST assign values to all 'out' parameters inside the method.
        public void GetValues(out int x, out int y)
        {
            x = 10;
            y = 20;
        }

        // 4️⃣ Using PARAMS keyword
        // 'params' lets you pass a variable number of arguments as an array.
        // You can pass multiple values separated by commas.
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
                sum += n;
            return sum;
        }
    }

    // 🔹 Example usage of the above methods
    public class Demo
    {
        public static void Main()
        {
            // Create an instance of the class
            MethodParameters mp = new MethodParameters();

            // 1️⃣ Passing by value
            int x = 5, y = 7;
            mp.PrintSum(x, y); // Output: Sum: 12
            // x and y remain unchanged because they were passed by value.

            // 2️⃣ Passing by reference (ref)
            int number = 10;
            mp.Increment(ref number); // number becomes 11
            System.Console.WriteLine($"After Increment: {number}");

            // 3️⃣ Using out parameters
            int a, b;
            mp.GetValues(out a, out b); // a=10, b=20 (values set inside method)
            System.Console.WriteLine($"Values from GetValues: a={a}, b={b}");

            // 4️⃣ Using params keyword
            int total = mp.SumAll(1, 2, 3, 4, 5); // can pass multiple integers
            System.Console.WriteLine($"Total Sum (params): {total}");
        }
    }
}
