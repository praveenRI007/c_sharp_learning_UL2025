// This file demonstrates the concept: Attributes in C#
namespace Topics.AccessModifiersAttributes
{
    // Attributes add metadata to code elements (classes, methods, properties, etc.)
    // Example: Creating and using a custom attribute
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public class InfoAttribute : System.Attribute
    {
        public string Description { get; }
        public InfoAttribute(string description)
        {
            Description = description;
        }
    }

    [Info("This class demonstrates usage of custom attributes.")]
    public class AttributesDemo
    {
        [Info("This method prints a message.")]
        public void Print()
        {
            Console.WriteLine("Attributes demo");
        }
    }
}
