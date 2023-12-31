namespace InterimTaskNine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];

            string[] animals = {"Cat", "Dog", "Bird", "Monkey"};

            int[] array1;
            array1 = new int[5];

            colors[0] = "Blue";
            array1[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(colors[0]);

            Console.WriteLine("Please enter the number of elements of the array:");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Please enter {0}. element: ", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (var number in numbers)
            {
                total += number;                
            }

            Console.WriteLine("Average: " + total / arrLength);
        }
    }
}
