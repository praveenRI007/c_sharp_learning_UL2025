// This file demonstrates the concept: Problems of multiple class inheritance
namespace Topics.PropertiesStructsInterfaces
{
    // C# does not support multiple inheritance for classes, but interfaces can be used to achieve similar behavior.
    public class A
    {
        public void MethodA() => Console.WriteLine("MethodA from A");
    }

    public class B
    {
        public void MethodB() => Console.WriteLine("MethodB from B");
    }

    // The following is NOT allowed in C#:
    // public class C : A, B { } // Error: Cannot inherit from multiple classes

    // Solution: Use interfaces
    public interface IA { void MethodA(); }
    public interface IB { void MethodB(); }

    public class C : IA, IB
    {
        public void MethodA() => Console.WriteLine("MethodA from IA");
        public void MethodB() => Console.WriteLine("MethodB from IB");
    }

    public class MultipleInheritanceProblems
    {
        public void Demo()
        {
            C obj = new C();
            obj.MethodA();
            obj.MethodB();
        }
    }
}
