// This file demonstrates the concept: Retrieving data from a Thread function using callback method
using System;
using System.Threading;

namespace Topics.Multithreading
{
    public class RetrievingDataFromThread
    {
        public void Demo()
        {
            string result = null;
            Thread t = new Thread(() => { result = "Thread finished!"; });
            t.Start();
            t.Join(); // Wait for thread to finish
            Console.WriteLine(result); // Output: Thread finished!
        }
    }
}
