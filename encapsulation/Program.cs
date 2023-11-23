namespace encapsulation
{
    class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ayşe";
            student.Surname = "Yılmaz";
            student.StudentNo = 293;
            student.Classroom = 3;
            student.GetStudentInfo();

            student.SkipClassroem();
            student.GetStudentInfo();

            Student student1 = new Student("Deniz", "Arda", 256, 1);
            student1.DownClassroem();
            student1.DownClassroem();
            student1.GetStudentInfo();
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classroom;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Classroom
        {
            get => classroom;
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Class can be at least 1.!");
                    classroom = 1;
                }
                else
                    classroom = value;
            }
        }

        public Student(string name, string surname, int studentNo, int classroom)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Classroom = classroom;
        }

        public Student() { }

        public void GetStudentInfo()
        {
            Console.WriteLine("********* Student Information *********");
            Console.WriteLine("Student Name             :{0}", this.Name);
            Console.WriteLine("Student Surname          :{0}", this.Surname);
            Console.WriteLine("Student No               :{0}", this.StudentNo);
            Console.WriteLine("Student Classroom        :{0}", this.Classroom);
        }

        public void SkipClassroem()
        {
            this.Classroom = this.Classroom + 1;
        }

        public void DownClassroem()
        {
            this.Classroom = this.Classroom - 1;
        }
    }
}