// This file demonstrates the concept: Arrays in C#
namespace Topics.Introduction_Basics
{
    public class ArraysDemo
    {
        public void Demo()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
