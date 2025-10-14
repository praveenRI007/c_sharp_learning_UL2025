// This file demonstrates the concept: Properties in C#
namespace Topics.PropertiesStructsInterfaces
{
    public class PropertiesDemo
    {
        // Auto-implemented property
        public string Name { get; set; }

        // Property with backing field
        private int _age;
        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }
    }
}
