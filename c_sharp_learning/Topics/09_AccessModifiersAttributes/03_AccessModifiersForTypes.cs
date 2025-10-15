// This file demonstrates the concept: Access modifiers for types
namespace Topics.AccessModifiersAttributes
{
    // public class: accessible from anywhere
    public class PublicType
    {
        public void Show() => System.Console.WriteLine("PublicType.Show()");
    }

    // internal class: accessible only within the same assembly
    internal class InternalType
    {
        public void Show() => System.Console.WriteLine("InternalType.Show()");
    }

    // Classes cannot be private or protected at namespace level
    // Nested classes can be private/protected
    public class OuterClass
    {
        private class PrivateNestedType
        {
            public void Show() => System.Console.WriteLine("PrivateNestedType.Show()");
        }

        public void Demo()
        {
            PrivateNestedType nested = new PrivateNestedType();
            nested.Show();
        }
    }

    public class AccessModifiersForTypes
    {
        public void Demo()
        {
            PublicType pub = new PublicType();
            pub.Show();

            InternalType internalType = new InternalType();
            internalType.Show();

            OuterClass outer = new OuterClass();
            outer.Demo();
        }
    }
}
