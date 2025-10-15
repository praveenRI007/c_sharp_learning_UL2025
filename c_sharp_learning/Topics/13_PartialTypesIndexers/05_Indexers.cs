// This file demonstrates the concept: Indexers in C#
namespace Topics.PartialTypesIndexers
{
    public class IndexersDemo
    {
        private string[] names = { "Alice", "Bob", "Charlie" };

        // Indexer property
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }

    public class Indexers
    {
        public void Demo()
        {
            IndexersDemo obj = new IndexersDemo();
            System.Console.WriteLine(obj[0]); // Output: Alice
            obj[0] = "Alex";
            System.Console.WriteLine(obj[0]); // Output: Alex
        }
    }
}
