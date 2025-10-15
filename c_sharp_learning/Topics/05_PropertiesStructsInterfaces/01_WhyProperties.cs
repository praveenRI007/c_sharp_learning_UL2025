// This file demonstrates the concept: Why Properties
namespace Topics.PropertiesStructsInterfaces
{
    public class WhyProperties
    {
        // 🔹 FIELDS (directly accessible variables)
        // Using public fields directly exposes internal data.
        // This is NOT recommended because it breaks encapsulation.
        public int PublicAge; // ❌ Not safe — can be set to invalid values

        // 🔹 Private field with methods for control
        // This approach adds validation but is verbose.
        private int _ageWithMethods;

        public void SetAge(int value)
        {
            if (value > 0)
                _ageWithMethods = value;
            else
                System.Console.WriteLine("Invalid age (must be positive)");
        }

        public int GetAge()
        {
            return _ageWithMethods;
        }

        // 🔹 Using PROPERTIES (recommended)
        // Combines field and getter/setter logic in a clean way.
        private int _age;

        public int Age
        {
            get { return _age; }  // Getter (read value)
            set                   // Setter (assign value)
            {
                if (value > 0)
                    _age = value;
                else
                    System.Console.WriteLine("Invalid age (must be positive)");
            }
        }

        // 🔹 Auto-implemented property (C# feature)
        // Used when no extra logic is needed in get/set.
        public string Name { get; set; } // Automatically creates a hidden backing field

        // 🔹 Demo method to show the difference
        public void Demo()
        {
            System.Console.WriteLine("=== Demonstrating Why Properties ===");

            // 1️⃣ Direct field access (unsafe)
            PublicAge = -5; // No restriction, can be invalid
            System.Console.WriteLine($"PublicAge: {PublicAge}");

            // 2️⃣ Using methods (safe but verbose)
            SetAge(25);
            System.Console.WriteLine($"_ageWithMethods (using GetAge): {GetAge()}");

            SetAge(-3); // Invalid value rejected

            // 3️⃣ Using properties (safe and elegant)
            Age = 30;
            System.Console.WriteLine($"Age (via property): {Age}");

            Age = -10; // Invalid value rejected

            // 4️⃣ Auto-property (no logic)
            Name = "Alice";
            System.Console.WriteLine($"Name (auto-property): {Name}");
        }
    }

    // 🔹 Optional entry point to run the demo
    public class Program
    {
        public static void Main()
        {
            WhyProperties demo = new WhyProperties();
            demo.Demo();
        }
    }
}
