// This file demonstrates the concept: Method Hiding
namespace Topics.ObjectOrientedProgramming
{
    // 🔹 BASE CLASS
    public class BaseClass
    {
        public void Show()
        {
            System.Console.WriteLine("BaseClass Show");
        }
    }

    // 🔹 DERIVED CLASS
    // The 'new' keyword is used to HIDE a method from the base class.
    // This is different from overriding (which uses 'virtual' and 'override').
    public class DerivedClass : BaseClass
    {
        public new void Show() // 'new' hides the base class method
        {
            System.Console.WriteLine("DerivedClass Show (hidden)");
        }
    }

    // 🔹 DEMONSTRATION CLASS
    public class MethodHiding
    {
        public void Demo()
        {
            // 1️⃣ Creating a BaseClass object
            BaseClass obj1 = new BaseClass();
            obj1.Show(); // Output: BaseClass Show

            // 2️⃣ Creating a DerivedClass object
            DerivedClass obj2 = new DerivedClass();
            obj2.Show(); // Output: DerivedClass Show (hidden)

            // 3️⃣ BaseClass reference holding a DerivedClass object
            // Even though the actual object is DerivedClass,
            // the reference type decides which 'Show' method is called.
            // Since 'Show' is hidden (not overridden), the base class version runs.
            BaseClass obj3 = new DerivedClass();
            obj3.Show(); // Output: BaseClass Show (method hiding)
        }
    }

    // 🔹 Optional: Entry point to run the demo
    public class Program1
    {
        public static void Main1()
        {
            MethodHiding demo = new MethodHiding();
            demo.Demo();
        }
    }
}
