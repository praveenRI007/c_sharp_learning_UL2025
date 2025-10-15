// This file demonstrates the concept: ParameterizedThreadStart delegate
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class ParameterizedThreadStartDelegate
    {
        public void Demo()
        {
            Thread t = new Thread(new ParameterizedThreadStart(PrintMessage));
            t.Start("Hello from ParameterizedThreadStart!");
        }

        void PrintMessage(object message)
        {
            Console.WriteLine(message);
        }
    }
}
