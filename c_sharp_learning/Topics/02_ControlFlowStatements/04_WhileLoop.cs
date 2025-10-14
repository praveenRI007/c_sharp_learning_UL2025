// This file demonstrates the concept: While loop in C#
namespace Topics.ControlFlowStatements
{
    public class WhileLoop
    {
        public void CountToFive()
        {
            int i = 1;
            while (i <= 5)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }
    }
}
