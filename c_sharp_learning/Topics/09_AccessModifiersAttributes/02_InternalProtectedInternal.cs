// This file demonstrates the concept: Internal and protected internal access modifiers
namespace Topics.AccessModifiersAttributes
{
    // internal: accessible only within the same assembly
    internal class InternalClass
    {
        public void Show() => System.Console.WriteLine("InternalClass.Show()");
    }

    // protected internal: accessible within the same assembly or from derived types
    public class BaseClass
    {
        protected internal void Display()
        {
            System.Console.WriteLine("BaseClass.Display() (protected internal)");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void CallDisplay()
        {
            // Can access protected internal member
            Display();
        }
    }

    public class InternalProtectedInternal
    {
        public void Demo()
        {
            InternalClass internalObj = new InternalClass();
            internalObj.Show();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.CallDisplay();
        }
    }
}
