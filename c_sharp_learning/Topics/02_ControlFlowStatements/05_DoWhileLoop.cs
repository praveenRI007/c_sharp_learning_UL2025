// This file demonstrates the concept: Do while loop in C#
namespace Topics.ControlFlowStatements
{
    public class DoWhileLoop
    {
        public void CountToFive()
        {
            int i = 1;
            do
            {
                System.Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}
