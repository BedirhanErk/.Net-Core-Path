namespace InterimTaskSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            int oddTotal = 0;
            int evenTotal = 0;
            for (int j = 1; j <= 1000; j++)
            {
                if (j % 2 == 1)
                    oddTotal += j;
                else
                    evenTotal += j;                
            }

            Console.WriteLine("Odd Total: " + oddTotal);
            Console.WriteLine("Even Total: " + evenTotal);

            Console.WriteLine("\n");

            for (int k = 1; k < 10; k++)
            {
                if (k == 4)
                    break;
                Console.WriteLine(k);
            }

            Console.WriteLine("\n");

            for (int k = 1; k < 10; k++)
            {
                if (k == 4)
                    continue;
                Console.WriteLine(k);
            }
        }
    }
}
