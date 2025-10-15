// This file demonstrates the concept: Performance of a multithreaded program
using System;
using System.Diagnostics;
using System.Threading;

namespace Topics.Multithreading
{
    public class MultithreadedPerformance
    {
        public void Demo()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Thread t1 = new Thread(() => Thread.Sleep(500));
            Thread t2 = new Thread(() => Thread.Sleep(500));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            sw.Stop();
            Console.WriteLine($"Elapsed time (multithreaded): {sw.ElapsedMilliseconds} ms");
        }
    }
}
