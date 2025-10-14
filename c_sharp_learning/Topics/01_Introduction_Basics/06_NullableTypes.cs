// This file demonstrates the concept: Nullable types
namespace Topics.Introduction_Basics
{
    public class NullableTypes
    {
        public void Demo()
        {
            int? maybeInt = null;
            if (maybeInt.HasValue)
            {
                Console.WriteLine($"Value: {maybeInt.Value}");
            }
            else
            {
                Console.WriteLine("No value");
            }
        }
    }
}
