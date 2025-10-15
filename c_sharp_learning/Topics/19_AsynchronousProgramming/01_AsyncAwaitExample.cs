// This file demonstrates the concept: Async and await in C# (example)
namespace Topics.AsynchronousProgramming
{
    public class AsyncAwaitExample
    {
        // Demonstrates an asynchronous method using async and await
        public async Task DemoAsync()
        {
            Console.WriteLine("Starting async operation...");
            await Task.Delay(1000); // Simulates an asynchronous operation
            Console.WriteLine("Async operation completed.");
        }
    }
}
