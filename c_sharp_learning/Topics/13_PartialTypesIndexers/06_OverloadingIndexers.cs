// This file demonstrates the concept: Overloading indexers in C#
namespace Topics.PartialTypesIndexers
{
    public class OverloadingIndexersDemo
    {
        private int[] numbers = { 1, 2, 3 };
        private string[] names = { "A", "B", "C" };

        // Indexer for int
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }

        // Overloaded indexer for string
        public string this[string key]
        {
            get
            {
                int idx = key.Length % names.Length;
                return names[idx];
            }
            set
            {
                int idx = key.Length % names.Length;
                names[idx] = value;
            }
        }
    }

    public class OverloadingIndexers
    {
        public void Demo()
        {
            OverloadingIndexersDemo obj = new OverloadingIndexersDemo();
            System.Console.WriteLine(obj[1]); // Output: 2
            obj[1] = 10;
            System.Console.WriteLine(obj[1]); // Output: 10
            System.Console.WriteLine(obj["Hello"]); // Output: C
            obj["Hello"] = "Z";
            System.Console.WriteLine(obj["Hello"]); // Output: Z
        }
    }
}
