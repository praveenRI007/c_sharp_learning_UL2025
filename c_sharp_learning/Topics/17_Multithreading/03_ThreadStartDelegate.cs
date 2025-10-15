// This file demonstrates the concept: ThreadStart delegate
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class ThreadStartDelegate
    {
        public void Demo()
        {
            Thread t = new Thread(new ThreadStart(PrintMessage));
            t.Start();
        }

        void PrintMessage()
        {
            Console.WriteLine("Hello from ThreadStart delegate!");
        }
    }
}
