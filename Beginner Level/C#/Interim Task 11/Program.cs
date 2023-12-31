namespace InterimTaskEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int result = Sum(a, b);
            Console.WriteLine(result);

            Methods method = new Methods();
            method.Print(result.ToString());

            int result2 = method.IncreaseAndSum(ref a, ref b);
            method.Print(result2.ToString());            
            method.Print((a + b).ToString());
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }

    class Methods
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }

        public int IncreaseAndSum(ref int value1, ref int value2)
        {
            value1+=1;
            value2+=1;
            return value1 + value2;
        }
    }
}