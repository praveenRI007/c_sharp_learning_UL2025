// This file demonstrates the concept: Passing data to the Thread function in a type-safe manner
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class PassingDataToThread
    {
        public void Demo()
        {
            int data = 42;
            Thread t = new Thread(() => PrintData(data));
            t.Start();
        }

        void PrintData(int value)
        {
            Console.WriteLine($"Data passed to thread: {value}");
        }
    }
}
