// This file demonstrates the concept: Difference between method overriding and method hiding
namespace Topics.ObjectOrientedProgramming
{
    public class Base
    {
        public virtual void Display()
        {
            System.Console.WriteLine("Base Display");
        }
    }

    public class OverrideDerived : Base
    {
        public override void Display()
        {
            System.Console.WriteLine("OverrideDerived Display");
        }
    }

    public class HideDerived : Base
    {
        public new void Display()
        {
            System.Console.WriteLine("HideDerived Display");
        }
    }

    public class OverridingVsHiding
    {
        public void Demo()
        {
            Base obj1 = new OverrideDerived();
            obj1.Display(); // OverrideDerived Display (overriding)

            Base obj2 = new HideDerived();
            obj2.Display(); // Base Display (hiding)
        }
    }
}
