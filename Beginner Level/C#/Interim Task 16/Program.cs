namespace InterimTaskSixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(23);
            numbers.Add(10);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(92);
            numbers.Add(34);

            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Orange");
            colors.Add("Yellow");
            colors.Add("Green");

            //Count
            Console.WriteLine(colors.Count);
            Console.WriteLine(numbers.Count);

            //Foreach
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }            

            numbers.ForEach(number => Console.WriteLine(number));
            colors.ForEach(color => Console.WriteLine(color));

            //Remove
            numbers.Remove(4);
            colors.Remove("Green");

            numbers.ForEach(number => Console.WriteLine(number));
            colors.ForEach(color => Console.WriteLine(color));         

            numbers.RemoveAt(0);   
            colors.RemoveAt(1);   

            numbers.ForEach(number => Console.WriteLine(number));
            colors.ForEach(color => Console.WriteLine(color));       

            //Contains
            if(numbers.Contains(10))
                Console.WriteLine("List contains 10.");          

            //IndexOf, BinarySearch
            Console.WriteLine(colors.IndexOf("Yellow"));
            Console.WriteLine(colors.BinarySearch("Yellow"));

            //Array to List
            string[] animals = {"Cat", "Dog", "Bird"};
            List<string> animalList = new List<string>(animals);

            //Clear
            animalList.Clear();

            //Class List
            List<Users> userList = new List<Users>();

            Users user1 = new Users();
            user1.Name = "Bedirhan";
            user1.Surname = "Erkılıç";
            user1.Age = 24;

            Users user2 = new Users();
            user2.Name = "Özcan";
            user2.Surname = "Çalışkan";
            user2.Age = 26;    

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newUserList = new List<Users>();

            newUserList.Add(new Users(){
                Name = "Deniz",
                Surname = "Arda",
                Age = 24
            });

            foreach (var user in userList)
            {
                Console.WriteLine("Name: " + user.Name);
                Console.WriteLine("Surname: " + user.Surname);
                Console.WriteLine("Age: " + user.Age);
            }

            newUserList.Clear();
        }
    }

    public class Users
    {
        public string? Name { get; set; }        
        public string? Surname { get; set; }
        public int Age { get; set; }
    }
}