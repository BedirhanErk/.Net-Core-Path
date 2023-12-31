namespace InterimTaskTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "999";
            int outNumber;

            bool result = int.TryParse(number, out outNumber);
            if (result)
            {
                Console.WriteLine("Success!");
                Console.WriteLine(outNumber);
            }
            else
                Console.WriteLine("Failed!");

            Methods instance = new Methods();
            instance.Total(4, 5, out int result2);
            Console.WriteLine(result2);

            int number2 = 999;
            instance.Print(number2.ToString());
            instance.Print(number2);
            instance.Print("Bedirhan", "Erkılıç");
        }
    }

    class Methods
    {
        public void Total(int a, int b, out int total)
        {
            total = a + b;
        }

        public void Print(string value)
        {
            Console.WriteLine(value);
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }  

        public void Print(string value, string value2)
        {
            Console.WriteLine(value + value2);
        }                
    }
}