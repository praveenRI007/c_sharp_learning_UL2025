// This file demonstrates the concept: Anonymous methods in C#
namespace Topics.AnonymousMethodsLambdasDelegates
{
    public class AnonymousMethods
    {
        public void Demo()
        {
            // Anonymous method assigned to a delegate
            System.Action greet = delegate { System.Console.WriteLine("Hello from anonymous method!"); };
            greet(); // Output: Hello from anonymous method!
        }
    }
}
