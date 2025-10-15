// This file demonstrates the concept: Generic Stack collection class
namespace Topics.Collections
{
    public class GenericStack
    {
        public void Demo()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            System.Console.WriteLine(stack.Pop());  // Output: 30
            System.Console.WriteLine(stack.Peek()); // Output: 20
        }
    }
}
