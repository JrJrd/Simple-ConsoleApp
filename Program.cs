using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 27, "NY", "US", "he/him");
            sam.SetHobbies(new string[] {
        "study",
        "play auto to play mobile games",
        "travel"
      });
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
