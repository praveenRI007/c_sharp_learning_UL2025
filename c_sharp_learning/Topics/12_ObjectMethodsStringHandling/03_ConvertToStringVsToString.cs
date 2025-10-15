// This file demonstrates the concept: Difference between Convert.ToString() and ToString()
namespace Topics.ObjectMethodsStringHandling
{
    public class ConvertToStringVsToString
    {
        public void Demo()
        {
            int number = 123;
            string s1 = number.ToString(); // Uses instance method, always works
            string s2 = System.Convert.ToString(number); // Handles nulls, works for objects

            object obj = null;
            // string s3 = obj.ToString(); // Throws NullReferenceException
            string s4 = System.Convert.ToString(obj); // Returns null (safe)

            System.Console.WriteLine($"ToString: {s1}, Convert.ToString: {s2}, Convert.ToString(null): {s4}");
        }
    }
}
