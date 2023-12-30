using System;

namespace InterimTaskFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Good morning");
            else if (time <= 18)
                Console.WriteLine("Have a good day");
            else
                Console.WriteLine("Good night");

            string result = time >= 6 && time < 11 ? "Good morning" : time <= 18 ? "Have a good day" : "Good night";
            Console.WriteLine(result);
        }
    }
}