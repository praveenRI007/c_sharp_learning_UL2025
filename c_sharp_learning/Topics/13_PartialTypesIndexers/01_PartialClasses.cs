// This file demonstrates the concept: Partial classes in C#
namespace Topics.PartialTypesIndexers
{
    // Partial class: definition can be split across multiple files
    public partial class ExamplePartialClass
    {
        public void MethodA() => System.Console.WriteLine("MethodA in part 1");
    }

    // In another file, you could have:
    // public partial class ExamplePartialClass
    // {
    //     public void MethodB() => System.Console.WriteLine("MethodB in part 2");
    // }

    public class PartialClasses
    {
        public void Demo()
        {
            ExamplePartialClass obj = new ExamplePartialClass();
            obj.MethodA(); // Output: MethodA in part 1
            // obj.MethodB(); // Would work if MethodB is defined in another part
        }
    }
}
