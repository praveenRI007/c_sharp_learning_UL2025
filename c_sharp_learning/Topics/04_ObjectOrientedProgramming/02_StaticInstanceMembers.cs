// This file demonstrates the concept: Static and Instance Class Members
// Namespace: used to organize code logically
namespace Topics.ObjectOrientedProgramming
{
    public class StaticInstanceMembers
    {
        // 🔹 STATIC MEMBER:
        // Belongs to the CLASS itself, not to any particular object.
        // Shared among ALL instances (only one copy exists in memory).
        public static int StaticCount = 0;

        // 🔹 INSTANCE MEMBER:
        // Belongs to each individual OBJECT created from this class.
        // Each object has its own separate copy.
        public int InstanceCount = 0;

        // 🔹 Constructor:
        // Runs each time a new object (instance) of the class is created.
        public StaticInstanceMembers()
        {
            // Each time an object is created:
            // StaticCount increases — shared across all objects.
            StaticCount++;

            // InstanceCount increases — only for this object.
            InstanceCount++;
        }
    }

    // 🔹 Demonstration class
    public class Demo
    {
        public static void Main()
        {
            // Before creating any object, static members exist.
            System.Console.WriteLine($"Initial StaticCount: {StaticInstanceMembers.StaticCount}");

            // Create first object
            StaticInstanceMembers obj1 = new StaticInstanceMembers();
            System.Console.WriteLine($"After obj1 created → StaticCount: {StaticInstanceMembers.StaticCount}, InstanceCount (obj1): {obj1.InstanceCount}");

            // Create second object
            StaticInstanceMembers obj2 = new StaticInstanceMembers();
            System.Console.WriteLine($"After obj2 created → StaticCount: {StaticInstanceMembers.StaticCount}, InstanceCount (obj2): {obj2.InstanceCount}");

            // Create third object
            StaticInstanceMembers obj3 = new StaticInstanceMembers();
            System.Console.WriteLine($"After obj3 created → StaticCount: {StaticInstanceMembers.StaticCount}, InstanceCount (obj3): {obj3.InstanceCount}");

            // Notice:
            // StaticCount increases with each new object — shared across all.
            // InstanceCount stays 1 for each individual object.
        }
    }
}
