namespace InterimTaskEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** While *****\n"); 

            Console.WriteLine("Please enter a number:");            
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int total = 0;

            while (counter <= number)
            {
                total += counter;
                counter++;
            }

            Console.WriteLine(total / number);

            Console.WriteLine("\r"); 

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }
            
            Console.WriteLine("\n"); 

            Console.WriteLine("***** Foreach *****\n"); 

            string[] brands = {"Mercedes", "Ford", "Opel", "BMW"};

            foreach (var brand in brands)
            {
                Console.WriteLine(brand);
            }
        }
    }
}
