// This file demonstrates the concept: Waiting for thread to finish without blocking
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Topics.AsynchronousProgramming
{
    public class WaitingForThreadFinish
    {
        // Demonstrates waiting for a thread to finish using Task
        public async Task DemoAsync()
        {
            Console.WriteLine("Starting background work...");
            await Task.Run(() => Thread.Sleep(1000)); // Runs on a background thread
            Console.WriteLine("Background work finished.");
        }
    }
}
