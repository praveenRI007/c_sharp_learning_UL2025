// This file demonstrates the concept: Real-time example of Queue collection class
using System;
using System.Collections.Generic;

namespace Topics.Collections
{
    public class QueueRealTimeExample
    {
        // Simulate a print job queue
        public void PrintJobQueueDemo()
        {
            Queue<string> printJobs = new Queue<string>();
            printJobs.Enqueue("Document1.pdf");
            printJobs.Enqueue("Report.xlsx");
            printJobs.Enqueue("Image.png");

            while (printJobs.Count > 0)
            {
                string job = printJobs.Dequeue();
                Console.WriteLine($"Printing: {job}");
            }
            // Output:
            // Printing: Document1.pdf
            // Printing: Report.xlsx
            // Printing: Image.png
        }
    }
}
