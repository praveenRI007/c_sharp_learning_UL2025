// This file demonstrates the concept: Difference between String and StringBuilder
namespace Topics.ObjectMethodsStringHandling
{
    public class StringVsStringBuilder
    {
        public void Demo()
        {
            // String: immutable, each change creates a new object
            string s = "Hello";
            s += " World";
            s += "!";
            System.Console.WriteLine(s); // Output: Hello World!

            // StringBuilder: mutable, efficient for many changes
            var sb = new System.Text.StringBuilder("Hello");
            sb.Append(" World");
            sb.Append("!");
            System.Console.WriteLine(sb.ToString()); // Output: Hello World!
        }
    }
}
