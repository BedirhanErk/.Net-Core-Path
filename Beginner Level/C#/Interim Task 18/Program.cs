namespace InterimTaskEighteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Ayşe";
            employee1.Surname = "Kara";
            employee1.EmployeeNo = 23415634;
            employee1.Department = "Human Resources";
            employee1.EmployeeInfo();

            Console.WriteLine("**********");

            Employee employee2 = new Employee();
            employee2.Name = "Deniz";
            employee2.Surname = "Arda";
            employee2.EmployeeNo = 25646789;
            employee2.Department = "Sales";
            employee2.EmployeeInfo();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int EmployeeNo { get; set; }
        public string Department { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Name: {0}", Name);
            Console.WriteLine("Employee Surname: {0}", Surname);
            Console.WriteLine("Employee EmployeeNo: {0}", EmployeeNo);
            Console.WriteLine("Employee Department: {0}", Department);
        }
    }
}
