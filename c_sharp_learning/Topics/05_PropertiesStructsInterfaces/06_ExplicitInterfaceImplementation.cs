// This file demonstrates the concept: Explicit interface implementation
namespace Topics.PropertiesStructsInterfaces
{
    public interface IPrinter
    {
        void Print();
    }

    public class Document : IPrinter
    {
        // Explicit interface implementation: only accessible via interface reference
        void IPrinter.Print()
        {
            System.Console.WriteLine("Printing document...");
        }
    }

    public class ExplicitInterfaceImplementation
    {
        public void Demo()
        {
            Document doc = new Document();
            // doc.Print(); // Error: Print is not accessible directly
            ((IPrinter)doc).Print(); // Works: Output "Printing document..."
        }
    }
}
