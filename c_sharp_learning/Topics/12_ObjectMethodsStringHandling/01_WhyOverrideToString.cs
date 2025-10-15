// This file demonstrates the concept: Why override ToString()
namespace Topics.ObjectMethodsStringHandling
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Override ToString to provide meaningful string representation
        public override string ToString()
        {
            return $"Person: Name={Name}, Age={Age}";
        }
    }

    public class WhyOverrideToString
    {
        public void Demo()
        {
            Person p = new Person { Name = "Alice", Age = 30 };
            System.Console.WriteLine(p.ToString()); // Output: Person: Name=Alice, Age=30
        }
    }
}
