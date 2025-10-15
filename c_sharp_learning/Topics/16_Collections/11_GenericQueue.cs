// This file demonstrates the concept: Generic Queue collection class
namespace Topics.Collections
{
    public class GenericQueue
    {
        public void Demo()
        {
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            System.Console.WriteLine(queue.Dequeue()); // Output: First
            System.Console.WriteLine(queue.Peek());    // Output: Second
        }
    }
}
