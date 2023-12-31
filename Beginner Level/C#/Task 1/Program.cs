using System.Security.Cryptography;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();
            //Third();   
            //Fourth();             
            Console.ReadLine();
        }

        public static void First()
        {
            Console.Write("DESCRIPTION:\n");
            Console.WriteLine("In a console application, ask the user to enter a positive number (n).");
            Console.WriteLine("Then ask the user to enter n positive numbers.");
            Console.WriteLine("Print the even numbers that the user entered to the console.\n");

            Console.Write("Enter a positive number: ");
            int n;
            do
            {
                string value = Console.ReadLine();
                if (int.TryParse(value, out n))
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("ERROR: The number you entered is not positive.");
                        Console.Write("Enter a positive number: ");
                    }
                    else
                        n = Convert.ToInt32(value);    
                }  
                else
                {
                    n = 0;
                    Console.WriteLine("ERROR: The value you entered is not a number.");
                    Console.Write("Enter a positive number: ");
                }               
            }
            while (n <= 0);

            Console.WriteLine("\r");
            Console.WriteLine("INFO: You need to enter {0} numbers.\n", n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the {0}. positive number: ", i + 1);
                int p;
                do
                {
                    string value2 = Console.ReadLine();
                    if (int.TryParse(value2, out p))
                    {
                        if (p <= 0)
                        {
                            Console.WriteLine("ERROR: The number you entered is not positive.");    
                            Console.Write("Enter the {0}. positive number: ", i + 1);     
                        }
                        else
                        {
                            p = Convert.ToInt32(value2); 
                            arr[i] = p;
                        }   
                    }  
                    else
                    {
                        p = 0;  
                        Console.WriteLine("ERROR: The value you entered is not a number."); 
                        Console.Write("Enter the {0}. positive number: ", i + 1);
                    }               
                }
                while (p <= 0);                             
            }            

            Console.WriteLine("\r");
            Console.Write("The even numbers you entered are as follows: ");
            if (arr != null && arr.Count() > 0)
            {
                foreach (var item in arr)
                {
                    if (item % 2 == 0)
                        Console.Write(item + " ");
                }
            }               
        }

        public static void Second()
        {
            Console.Write("DESCRIPTION:\n");
            Console.WriteLine("In a console application, ask the user to enter two positive numbers (n, m).");
            Console.WriteLine("Then ask the user to enter n positive numbers.");
            Console.WriteLine("Print the numbers that are equal to or exactly divisible by m from the numbers entered by the user to the console.\n");

            Console.Write("Enter the 1st positive number (n): ");
            int n;
            do
            {
                string value = Console.ReadLine();
                if (int.TryParse(value, out n))
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("ERROR: The number you entered is not positive.");
                        Console.Write("Enter the 1st positive number (n): ");       
                    }
                    else
                        n = Convert.ToInt32(value);    
                }  
                else
                {
                    n = 0;  
                    Console.WriteLine("ERROR: The value you entered is not a number.");      
                    Console.Write("Enter the 1st positive number (n): ");
                }               
            }
            while (n <= 0);

            Console.Write("Enter the 2nd positive number (m): ");
            int m;
            do
            {
                string value2 = Console.ReadLine();
                if (int.TryParse(value2, out m))
                {
                    if (m <= 0)
                    {
                        Console.WriteLine("ERROR: The number you entered is not positive."); 
                        Console.Write("Enter the 2nd positive number (m): "); 
                    }
                    else
                        m = Convert.ToInt32(value2);    
                }  
                else
                {
                    m = 0;
                    Console.WriteLine("ERROR: The value you entered is not a number.");  
                    Console.Write("Enter the 2nd positive number (m): ");
                }               
            }
            while (m <= 0);         

            Console.WriteLine("\r");
            Console.WriteLine("You need to enter {0} numbers.\n", n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the {0}. positive number: ", i + 1);
                int p;
                do
                {
                    string value3 = Console.ReadLine();
                    if (int.TryParse(value3, out p))
                    {
                        if (p <= 0)
                        {
                            Console.WriteLine("ERROR: The number you entered is not positive.");
                            Console.Write("Enter the {0}. positive number: ", i + 1);
                        }
                        else
                        {
                            p = Convert.ToInt32(value3); 
                            arr[i] = p;
                        }   
                    }  
                    else
                    {
                        p = 0;  
                        Console.WriteLine("ERROR: The value you entered is not a number.");                             
                        Console.Write("Enter the {0}. positive number: ", i + 1);
                    }               
                }
                while (p <= 0);                
            }         


            Console.WriteLine("\r");
            Console.Write("Numbers that are equal to or exactly divisible by the 2nd number (m) are: ");
            if (arr != null && arr.Count() > 0)
            {
                foreach (var item in arr)
                {
                    if (item == m || item % m == 0)
                        Console.Write(item + " ");                     
                }
            }  
        }

        public static void Third()
        {
            Console.Write("DESCRIPTION:\n");
            Console.WriteLine("In a console application, ask the user to enter a positive number (n).");
            Console.WriteLine("Then ask the user to enter up to n words.");
            Console.WriteLine("Print the words entered by the user to the console from the end to the beginning.\n");

            Console.Write("Enter a positive number: ");
            int n;
            do
            {
                string value = Console.ReadLine();
                if (int.TryParse(value, out n))
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("ERROR: The number you entered is not positive.");
                        Console.Write("Enter a positive number: ");       
                    }
                    else
                        n = Convert.ToInt32(value);    
                }  
                else
                {
                    n = 0;  
                    Console.WriteLine("ERROR: The value you entered is not a number.");      
                    Console.Write("Enter a positive number: ");
                }               
            }
            while (n <= 0);          

            Console.WriteLine("\r");
            Console.WriteLine("You need to enter {0} words.\n", n);
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the {0}. word: ", i + 1);
                string p = Console.ReadLine();
                arr[i] = p;               
            }      

            Console.WriteLine("\r");
            Console.Write("The spelling of the words you entered from the end to the beginning: ");
            if (arr != null && arr.Count() > 0)
            {
                Array.Reverse(arr);
                foreach (var item in arr)
                {
                    Console.Write(item + " ");                     
                }
            }              
        }

        public static void Fourth()
        {
            Console.Write("DESCRIPTION:\n");
            Console.WriteLine("In a console application, ask the user to type a sentence.");
            Console.WriteLine("Print the total number of words and letters in the sentence to the console.\n");

            Console.WriteLine("Enter a sentence:");
            string value = Console.ReadLine();

            Console.WriteLine("The number of words in the sentence you wrote: " + value.Split(" ").Count());

            var arr = value.ToCharArray();

            Console.WriteLine("The number of letters in the sentence you wrote: " + arr.Count());            
        }
    }
}