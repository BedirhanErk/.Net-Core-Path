using System.Collections;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESCRIPTION:\n");
            Console.WriteLine("Write the programme that stores the vowels in the sentence entered from the keyboard in an array and sorts the elements of the array.\n");

            Console.WriteLine("INFO: You must enter a sentence.");

            ArrayList vowels = new ArrayList();
            
            string sentence = "";

            do
            {
                Console.Write("Write a sentence: ");
                sentence = Console.ReadLine();
            }
            while(sentence == "");

            if(sentence != null && sentence != "")
            {
                foreach (var letter in sentence)
                {
                    if(letter == 'a' 
                    || letter == 'e'  
                    || letter == 'i' 
                    || letter == 'o' 
                    || letter == 'u')
                        vowels.Add(letter);
                }
            }

            vowels.Sort();

            foreach (var item in vowels)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
