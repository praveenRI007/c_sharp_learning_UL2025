// This file demonstrates the concept: Switch statement in C#
namespace Topics.ControlFlowStatements
{
    public class SwitchStatement
    {
        public void ShowDay(int day)
        {
            switch (day)
            {
                case 1:
                    System.Console.WriteLine("Monday");
                    break;
                case 2:
                    System.Console.WriteLine("Tuesday");
                    break;
                case 3:
                    System.Console.WriteLine("Wednesday");
                    break;
                default:
                    System.Console.WriteLine("Other day");
                    break;
            }
        }
    }
}
