// This file demonstrates the concept: How and where indexers are used in .NET
namespace Topics.PartialTypesIndexers
{
    // Indexers allow objects to be indexed like arrays
    public class IndexersUsageDemo
    {
        private int[] numbers = { 10, 20, 30 };

        // Indexer property
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }
    }

    public class IndexersUsage
    {
        public void Demo()
        {
            IndexersUsageDemo obj = new IndexersUsageDemo();
            System.Console.WriteLine(obj[1]); // Output: 20
            obj[1] = 99;
            System.Console.WriteLine(obj[1]); // Output: 99
        }
    }
}
