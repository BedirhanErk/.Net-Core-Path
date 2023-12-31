namespace InterimTaskThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }

            Console.WriteLine(result);

            Methods instance = new Methods();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension
            string value3 = "Bedirhan Erkılıç";
            bool result2 = value3.CheckSpaces();
            Console.WriteLine(result2);
            if(result2)
                Console.WriteLine(value3.RemoveWhiteSpaces());
            Console.WriteLine(value3.MakeUpperCase());
            Console.WriteLine(value3.MakeLowerCase());

            int[] array = {9, 3, 6, 2, 1, 5, 0};
            array.SortArr();
            array.PrintScreen();

            int number = 5;
            Console.WriteLine(number.IsEven());

            Console.WriteLine(value3.GetFirstChar());
        }
    }

    public class Methods
    {
        public int Expo(int value1, int value2)
        {
            if (value2 < 2)
                return value1;
            return Expo(value1, value2 - 1) * 3;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        } 

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }         

        public static int[] SortArr(this int[] param)
        {
            Array.Sort(param);
            return param;
        }       

        public static void PrintScreen(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }
    }    
}