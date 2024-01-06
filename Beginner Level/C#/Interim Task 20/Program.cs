using System.ComponentModel;

namespace InterimTaskTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ayşe";
            student.Surname = "Yılmaz";
            student.No = 293;
            student.StudentClass = 3;
            student.GetStudentInfo();

            student.NextClass();
            student.GetStudentInfo();

            Student student2 = new Student("Deniz", "Arda", 256, 1);
            student2.GetStudentInfo();
            
            student2.PreviousClass();
            student2.PreviousClass();
            student2.GetStudentInfo();
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int no;
        private int studentClass;

        public string Name 
        {      
            get { return name; } 
            set { name = value; }
        }

        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public int StudentClass 
        { 
            get => studentClass; 
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("The class cannot be smaller than one.");
                    studentClass = 1;
                }                
                else
                    studentClass = value;
            }
        }

        public Student(){}

        public Student(string name, string surname, int no, int studentClass)
        {
            Name = name;
            Surname = surname;
            No = no;
            StudentClass = studentClass;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("***** Student Info *****");
            Console.WriteLine("Name    :{0}", this.Name);
            Console.WriteLine("Surname :{0}", this.Surname);
            Console.WriteLine("No      :{0}", this.No);
            Console.WriteLine("Class   :{0}", this.StudentClass);
        }

        public void NextClass()
        {
            this.StudentClass++;
        }

        public void PreviousClass()
        {
            this.StudentClass--;
        }
    }
}
