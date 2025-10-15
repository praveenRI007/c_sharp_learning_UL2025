// This file demonstrates the concept: Enums in C#
namespace Topics.EnumsTypeMembers
{
    // Enum with explicit underlying values
    public enum StatusCode
    {
        Success = 200,
        NotFound = 404,
        ServerError = 500
    }

    public class EnumsInCSharp
    {
        public void PrintStatus(StatusCode code)
        {
            System.Console.WriteLine($"Status: {code} ({(int)code})");
        }
    }
}
