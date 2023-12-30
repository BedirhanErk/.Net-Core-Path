using System;

namespace InterimTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Example Start
            string str1 = string.Empty;
            str1 = "Bedirhan Erkılıç";
            string name = "Bedirhan";
            string surname = "Erkılıç";
            string fullName = name + " " + surname;
            Console.WriteLine("Example 1: " + fullName);
            //string Example End

            //int Example Start
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            Console.WriteLine("Example 2: " + integer3);
            //int Example End

            //bool Example Start
            bool boolean1 = 10 < 2;
            bool boolean2 = 10 > 2;   
            Console.WriteLine("Example 3: " + boolean1);
            Console.WriteLine("Example 4: " + boolean2);         
            //bool Example End

            //Convert-Parse Example Start
            string str2 = "20";
            int integer4 = 20;

            string str3 = str2 + integer4.ToString();
            Console.WriteLine("Example 5: " + str3);

            int integer5 = integer4 + Convert.ToInt32(str2);
            Console.WriteLine("Example 6: " + integer5);

            int integer6 = integer4 + int.Parse(str2);
            Console.WriteLine("Example 7: " + integer6);            
            //Convert-Parse Example End

            //DateTime Example Start
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string dateTime3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            Console.WriteLine("Example 8: " + dateTime);
            Console.WriteLine("Example 9: " + dateTime2);
            Console.WriteLine("Example 10: " + dateTime3);
            //DateTime Example End

            Console.ReadLine();
        }
    }
}