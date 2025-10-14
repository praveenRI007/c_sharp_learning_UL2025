// This file demonstrates the concept: Namespaces
namespace Topics.Methods_Parameters
{
    // This class is in the Topics.Methods_Parameters namespace
    public class NamespacesDemo
    {
        public void ShowNamespace()
        {
            System.Console.WriteLine($"Namespace: {typeof(NamespacesDemo).Namespace}");
        }
    }
}

// Another namespace example
namespace Demo.Utilities
{
    public class Utility
    {
        public static void PrintHello()
        {
            System.Console.WriteLine("Hello from Demo.Utilities namespace!");
        }
    }
}
