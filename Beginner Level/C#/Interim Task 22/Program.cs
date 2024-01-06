namespace Interim_TaskTwentyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            int temperature = 32;

            if(temperature <= (int)Weather.Snowy)
                Console.WriteLine("It is Snowy.");
            else if(temperature > (int)Weather.Snowy && temperature <= (int)Weather.Stormy)
                Console.WriteLine("It is Stormy."); 
            else if(temperature > (int)Weather.Stormy && temperature <= (int)Weather.Rainy)
                Console.WriteLine("It is Rainy.");   
            else if(temperature >= (int)Weather.Sunny)
                Console.WriteLine("It is Sunny."); 
            else    
                Console.WriteLine("Weather forecast is unknown");                  
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 23,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Snowy = 5,
        Stormy = 8,
        Rainy = 15,                        
        Sunny = 30
    }
}
