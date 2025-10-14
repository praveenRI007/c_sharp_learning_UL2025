// This file demonstrates the concept: Why Enums
namespace Topics.EnumsTypeMembers
{
    // Enum for days of the week
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class WhyEnums
    {
        public void PrintDay(DayOfWeek day)
        {
            System.Console.WriteLine($"Today is: {day}");
        }
    }
}
