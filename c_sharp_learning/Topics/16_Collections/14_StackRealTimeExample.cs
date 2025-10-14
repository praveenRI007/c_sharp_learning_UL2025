// This file demonstrates the concept: Real-time example of Stack collection class
using System;
using System.Collections.Generic;

namespace Topics.Collections
{
    public class StackRealTimeExample
    {
        public void BrowserBackButtonSimulation()
        {
            Stack<string> history = new Stack<string>();
            history.Push("Home");
            history.Push("About");
            history.Push("Contact");

            Console.WriteLine($"Current page: {history.Peek()}"); // Contact
            history.Pop(); // Go back
            Console.WriteLine($"After going back, current page: {history.Peek()}"); // About
        }
    }
}
