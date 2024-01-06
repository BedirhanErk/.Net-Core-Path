namespace InterimTaskNineteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Employee 1 *****");
            Employee employee1 = new Employee("Ayşe", "Kara", 23415634, "Human Resources");
            employee1.EmployeeInfo();

            Console.WriteLine("***** Employee 2 *****");
            Employee employee2 = new Employee("Deniz", "Arda");
            employee2.Name = "Deniz";
            employee2.Surname = "Arda";
            employee2.EmployeeNo = 25646789;
            employee2.Department = "Sales";
            employee2.EmployeeInfo();

            Console.WriteLine("***** Employee 3 *****");
            Employee employee3 = new Employee("Bedirhan", "Erkılıç");
            employee3.EmployeeInfo();         
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int EmployeeNo { get; set; }
        public string Department { get; set; }

        public Employee(string name, string surname, int no, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.EmployeeNo = no;
            this.Department = department;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }        

        public Employee(){}

        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee EmployeeNo: {0}", EmployeeNo);
            Console.WriteLine("Employee Department: {0}", Department);
        }
    }    
}
