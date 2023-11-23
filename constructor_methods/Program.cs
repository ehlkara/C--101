namespace constructor_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // class className
            // {
            //    [Access Modifier] [Value Type] featureName;
            //    [Access Modifier] [Return Value] MethodName([Parameter List])
            //    {
            //      // Method commands
            //    }
            // }

            //Access Modifier
            // * Public
            // * Private
            // * Internal
            // * Protected

            Console.WriteLine("********* Employee 1*********");
            Employee employee1 = new Employee("Ehlullah","Karakurt", 23415634, "People culture");
            employee1.EmployeeInformation();

            Console.WriteLine("********* Employee 2*********");
            Employee employee2 = new Employee();
            employee2.Name = "Deniz";
            employee2.Surname = "Arda";
            employee2.No = 25646789;
            employee2.Department = "Sales Department";

            employee2.EmployeeInformation();

            Console.WriteLine("********* Employee 3*********");
            Employee employee3 = new Employee("Ehlullah", "Karakurt");
            employee3.EmployeeInformation();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee(string name, string surname, int no, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee()
        {

        }

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee No:{0}", No);
            Console.WriteLine("Employee Department:{0}", Department);
        }
    }
}