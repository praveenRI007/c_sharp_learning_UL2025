// This file demonstrates the concept: Data type conversion
namespace Topics.Introduction_Basics
{
    public class DataTypeConversion
    {
        public void Demo()
        {
            int i = 42;
            double d = i; // Implicit
            int j = (int)d; // Explicit
            string s = i.ToString();
            int parsed = int.Parse(s);
        }
    }
}
