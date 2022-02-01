using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {

            // constructor method being used for input
            Profile sam = new Profile("Sam", 16, "New York", "America", "he/him");

            // setting hobbies using hobby method
            sam.SetHobbies(new string[] { "He likes to play soccer", "He likes to enjoy music" });

            // view profile method 
            string profileInfo = sam.ViewProfile();
            Console.WriteLine(profileInfo);

        }
    }
}
