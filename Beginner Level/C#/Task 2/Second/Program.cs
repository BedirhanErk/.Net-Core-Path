namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESCRIPTION:\n");
            Console.WriteLine("Write a programme that finds the 3 biggest and 3 lowest numbers of the 20 numbers entered from the keyboard.");
            Console.WriteLine("Averages these two groups and prints these averages and average sums to the console.\n");

            Console.WriteLine("INFO: You must enter 20 numbers.");

            int[] list = new int[20];

            var itemCount = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");

                int number;     
                do
                {
                    string value = Console.ReadLine();
                    if (int.TryParse(value, out number))
                    {
                        list[i] = number;                         
                        itemCount++;
                    }  
                    else
                    {
                        Console.WriteLine("ERROR: You have entered a non-numeric value, try again.");
                        Console.Write("Number " + (i + 1) + ": ");
                    }               
                }
                while (itemCount == i);
            }            

            int[] biggestNumbers = new int[3];
            int[] lowestNumbers = new int[3];

            Array.Sort(list);

            for (int i = 0; i < 3; i++)
            {
                biggestNumbers[i] = list[(19 - i)];                
                lowestNumbers[i] = list[i];
            }

            Console.WriteLine("\r");

            Console.WriteLine("Average of the 3 Biggest Numbers: " + biggestNumbers.Average());
            Console.WriteLine("Average of the 3 Lowest Numbers: " + lowestNumbers.Average());
            Console.WriteLine("The Average Sum of 2 Groups of the Lowest and Biggest Numbers: " + (biggestNumbers.Average() + lowestNumbers.Average()));

            Console.ReadLine();
        }
    }
}
