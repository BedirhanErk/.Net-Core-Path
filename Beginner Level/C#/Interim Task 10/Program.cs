namespace InterimTaskTen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            Console.WriteLine("***** Sort *****"); 

            int[] numbers = {23, 12, 4, 86, 72, 3, 11, 17};

            Console.WriteLine("***** Unsorted Array *****");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("***** Sorted Array *****");       
            Array.Sort(numbers);  
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }      

            //Clear
            Console.WriteLine("***** Clear *****");

            Array.Clear(numbers, 2, 2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }           

            //Reverse
            Console.WriteLine("***** Reverse *****");           

            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }      

            //IndexOf
            Console.WriteLine("***** IndexOf *****");       

            Console.WriteLine(Array.IndexOf(numbers, 23));                   

            //Resize
            Console.WriteLine("***** Resize *****");       

            Array.Resize(ref numbers, 9);
            numbers[8] = 99;

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
