// This file demonstrates the concept: Reading and writing to a console
namespace Topics.Introduction_Basics
{
    public class ReadingWritingConsole
    {
        public static void Demo()
        {
            Console.WriteLine("Hello, Console!");
            var input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");
        }
    }
}
