// This file demonstrates the concept: Creating partial classes in C#
namespace Topics.PartialTypesIndexers
{
    // First part of the partial class
    public partial class MyPartialClass
    {
        public void PartOne() => System.Console.WriteLine("Part one of partial class");
    }

    // Second part of the partial class (would be in another file in practice)
    public partial class MyPartialClass
    {
        public void PartTwo() => System.Console.WriteLine("Part two of partial class");
    }

    public class CreatingPartialClasses
    {
        public void Demo()
        {
            MyPartialClass obj = new MyPartialClass();
            obj.PartOne(); // Output: Part one of partial class
            obj.PartTwo(); // Output: Part two of partial class
        }
    }
}
