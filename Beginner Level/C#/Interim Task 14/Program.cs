namespace InterimTaskFourteen
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Welcome to our csharp class.";
            string value2 = "Welcome";

            //Length
            Console.WriteLine(value.Length);

            //ToUpper, ToLower
            Console.WriteLine(value.ToUpper());
            Console.WriteLine(value.ToLower());

            //Concat
            Console.WriteLine(String.Concat(value, " Hi!"));

            //Compare, CompareTo
            Console.WriteLine(value.CompareTo(value2));
            Console.WriteLine(String.Compare(value, value2, true));
            Console.WriteLine(String.Compare(value, value2, false));

            //Contains, EndsWith, StartsWith
            Console.WriteLine(value.Contains(value2));
            Console.WriteLine(value.EndsWith("class."));
            Console.WriteLine(value.StartsWith("Hi"));

            //IndexOf, LastIndexOf
            Console.WriteLine(value.IndexOf("to"));
            Console.WriteLine(value.IndexOf("Bedirhan"));
            Console.WriteLine(value.LastIndexOf("s"));

            //Insert
            Console.WriteLine(value.Insert(0, "Hi! "));

            //PadLeft, PadRight
            Console.WriteLine(value + value2.PadLeft(30));
            Console.WriteLine(value + value2.PadLeft(30, '*'));
            Console.WriteLine(value.PadRight(50) + value2);
            Console.WriteLine(value.PadRight(50, '-') + value2);
            Console.WriteLine(value.PadRight(50, '-') + value2.PadLeft(30, '*'));

            //Remove
            Console.WriteLine(value.Remove(10));
            Console.WriteLine(value.Remove(5, 3));
            Console.WriteLine(value.Remove(0, 1));

            //Replace
            Console.WriteLine(value.Replace("csharp", "C#"));
            Console.WriteLine(value.Replace(" ", "*"));

            //Split
            Console.WriteLine(value.Split(" ")[1]);

            //Substring
            Console.WriteLine(value.Substring(4));
            Console.WriteLine(value.Substring(4, 6));
        }
    }
}