// This file demonstrates the concept: Enums Example
namespace Topics.EnumsTypeMembers
{
    // Enum for traffic light states
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public class EnumsExample
    {
        public void ShowLight(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    System.Console.WriteLine("Stop!");
                    break;
                case TrafficLight.Yellow:
                    System.Console.WriteLine("Get Ready!");
                    break;
                case TrafficLight.Green:
                    System.Console.WriteLine("Go!");
                    break;
            }
        }
    }
}
