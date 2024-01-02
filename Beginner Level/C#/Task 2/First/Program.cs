using System.Collections;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESCRIPTION:\n");
            Console.WriteLine("Put the 20 positive numbers entered from the keyboard into 2 separate lists as prime and non-prime. (Write using the ArrayList class.)");
            Console.WriteLine("- Block negative and non-numeric entries.");
            Console.WriteLine("- Print the elements of each array on the screen in descending order.");
            Console.WriteLine("- Print the number of elements and the average of both arrays on the screen\n");

            Console.WriteLine("INFO: You must enter 20 numbers.");

            ArrayList list = new ArrayList();
          
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Number " + i + ": ");

                int number;     
                do
                {
                    string value = Console.ReadLine();
                    if (int.TryParse(value, out number))
                    {
                        if (number < 0)
                        {
                            Console.WriteLine("ERROR: You have entered a negative number, try again.");
                            Console.Write("Number " + i + ": ");
                        }
                        else
                            list.Add(number); 
                    }  
                    else
                    {
                        Console.WriteLine("ERROR: You have entered a non-numeric value, try again.");
                        Console.Write("Number " + i + ": ");
                    }               
                }
                while (list.Count != i);
            }

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();    

            foreach(var item in list)
            {
                if(Convert.ToInt32(item) < 2)
                {
                    nonPrimeNumbers.Add(item);
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(Convert.ToDouble(item)); i++)
                {
                    if(Convert.ToInt32(item) % i == 0)
                    {
                        nonPrimeNumbers.Add(item);    
                        isPrime = false;                 
                        break;
                    }
                }

                if (isPrime)
                    primeNumbers.Add(item);
            }        

            int sumOfPrime = 0;
            int sumOfNonPrime = 0;

            Console.WriteLine("\r");
            Console.WriteLine("Prime Numbers:");

            primeNumbers.Sort();
            primeNumbers.Reverse();
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
                sumOfPrime += Convert.ToInt32(item);
            }

            Console.WriteLine("Number of Elements: " + primeNumbers.Count);            
            Console.WriteLine("Average of Numbers: " + (sumOfPrime / (primeNumbers.Count == 0 ? 1 : primeNumbers.Count)) + "\n");     

            Console.WriteLine("Non-Prime Numbers:"); 
            nonPrimeNumbers.Sort();
            nonPrimeNumbers.Reverse();              
            foreach (var item in nonPrimeNumbers)
            {
                Console.WriteLine(item);
                sumOfNonPrime += Convert.ToInt32(item);
            }                 

            Console.WriteLine("Number of Elements: " + nonPrimeNumbers.Count);            
            Console.WriteLine("Average of Numbers: " + (sumOfNonPrime / (nonPrimeNumbers.Count == 0 ? 1 : nonPrimeNumbers.Count)));            

            Console.ReadLine();
        }
    }
}
