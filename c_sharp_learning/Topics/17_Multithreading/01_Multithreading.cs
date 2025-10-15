// This file demonstrates the concept: Multithreading in C#
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class MultithreadingDemo
    {
        public void Demo()
        {
            Thread t = new Thread(() => Console.WriteLine("Hello from another thread!"));
            t.Start();
            Console.WriteLine("Hello from main thread!");
        }
    }
}
