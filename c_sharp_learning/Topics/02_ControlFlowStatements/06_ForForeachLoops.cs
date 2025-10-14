// This file demonstrates the concept: For and foreach loops in C#
namespace Topics.ControlFlowStatements
{
    public class ForForeachLoops
    {
        public void ShowLoops()
        {
            // For loop
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"For loop: {i}");
            }

            // Foreach loop
            int[] numbers = { 1, 2, 3 };
            foreach (var n in numbers)
            {
                System.Console.WriteLine($"Foreach loop: {n}");
            }
        }
    }
}
