namespace InterimTaskTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);
         
            Employee employee = new Employee("Ayşe", "Yılmaz", "HR");

            Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

            Employee employee2 = new Employee("Deniz", "Arda", "IK");
            Employee employee3 = new Employee("Bedirhan", "Erkılıç", "IK");

            Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

            Console.WriteLine("Sum: {0}", Transactions.Sum(100, 200));
            Console.WriteLine("Extract: {0}", Transactions.Extract(400, 50));
        }
    }

    class Employee
    {
        private static int employeeCount;

        public static int EmployeeCount { get => employeeCount; }

        private string name;
        private string surname;
        private string department;

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            employeeCount++;
        }
    }

    static class Transactions
    {
        public static long Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static long Extract(int number1, int number2)
        {
            return number1 - number2;
        }        
    }
}
