// This file demonstrates the concept: Thread Join and Thread IsAlive functions
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class ThreadJoinIsAlive
    {
        public void Demo()
        {
            Thread t = new Thread(() => Thread.Sleep(1000));
            t.Start();
            Console.WriteLine($"IsAlive before join: {t.IsAlive}");
            t.Join(); // Wait for thread to finish
            Console.WriteLine($"IsAlive after join: {t.IsAlive}");
        }
    }
}
