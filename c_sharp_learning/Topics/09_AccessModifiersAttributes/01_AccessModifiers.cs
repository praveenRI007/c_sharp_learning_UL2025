// This file demonstrates the concept: Access modifiers in C#
namespace Topics.AccessModifiersAttributes
{
    public class AccessModifiersDemo
    {
        // public: accessible from anywhere
        public int PublicValue = 1;

        // private: accessible only within this class
        private int PrivateValue = 2;

        // protected: accessible within this class and derived classes
        protected int ProtectedValue = 3;

        // internal: accessible within the same assembly
        internal int InternalValue = 4;

        // protected internal: accessible within the same assembly or derived classes
        protected internal int ProtectedInternalValue = 5;

        // private protected: accessible within this class or derived classes in the same assembly
        private protected int PrivateProtectedValue = 6;

        public void Demo()
        {
            System.Console.WriteLine($"Public: {PublicValue}");
            System.Console.WriteLine($"Private: {PrivateValue}");
            System.Console.WriteLine($"Protected: {ProtectedValue}");
            System.Console.WriteLine($"Internal: {InternalValue}");
            System.Console.WriteLine($"Protected Internal: {ProtectedInternalValue}");
            System.Console.WriteLine($"Private Protected: {PrivateProtectedValue}");
        }
    }
}
