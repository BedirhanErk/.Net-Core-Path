using System;

namespace InterimTaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number you entered is: " + number);        
            }
            catch (Exception ex)
            {          
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Process Completed.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-11111111111");
            }
            catch (ArgumentNullException ex)
            {             
                Console.WriteLine("You entered a null value.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data type not suitable.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You have entered a value that is too high or too low.");
                Console.WriteLine(ex);
            }     
            finally
            {
                Console.WriteLine("Process Completed.");
            }       
        }
    }
}
