// This file demonstrates the concept: Delegates in C#
namespace Topics.DelegatesEvents
{
    // Define a delegate type
    public delegate void SimpleDelegate(string message);

    public class DelegatesDemo
    {
        public void ShowDelegateUsage()
        {
            SimpleDelegate del = PrintMessage;
            del("Hello from delegate!");
        }

        private void PrintMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}
