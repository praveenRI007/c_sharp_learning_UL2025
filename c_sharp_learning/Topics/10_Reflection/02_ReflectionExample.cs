// This file demonstrates the concept: Reflection example
using System;
using System.Reflection;

namespace Topics.Reflection
{
    public class ReflectionExample
    {
        public void ShowTypeInfo()
        {
            Type type = typeof(SampleClass);
            Console.WriteLine($"Type Name: {type.Name}");
            Console.WriteLine("Methods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"- {method.Name}");
            }
        }
    }

    public class SampleClass
    {
        public void MethodA() { }
        public int MethodB(int x) => x * 2;
    }
}
