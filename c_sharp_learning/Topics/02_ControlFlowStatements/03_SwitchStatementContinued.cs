// This file demonstrates the concept: Switch statement in C# (continued)
namespace Topics.ControlFlowStatements
{
    public class SwitchStatementContinued
    {
        public void ShowPatternMatching(object obj)
        {
            switch (obj)
            {
                case int i:
                    System.Console.WriteLine($"Integer: {i}");
                    break;
                case string s:
                    System.Console.WriteLine($"String: {s}");
                    break;
                case null:
                    System.Console.WriteLine("Null value");
                    break;
                default:
                    System.Console.WriteLine("Other type");
                    break;
            }
        }
    }
}
