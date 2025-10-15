// This file demonstrates the concept: Partial methods in C#
namespace Topics.PartialTypesIndexers
{
    public partial class PartialMethodExample
    {
        // Declaration of a partial method
        partial void OnSomethingHappened();

        public void DoSomething()
        {
            System.Console.WriteLine("Doing something...");
            OnSomethingHappened(); // Will call implementation if provided
        }
    }

    // Implementation of the partial method (would be in another file)
    public partial class PartialMethodExample
    {
        partial void OnSomethingHappened()
        {
            System.Console.WriteLine("Partial method executed!");
        }
    }

    public class PartialMethods
    {
        public void Demo()
        {
            PartialMethodExample obj = new PartialMethodExample();
            obj.DoSomething(); // Output: Doing something...\nPartial method executed!
        }
    }
}
