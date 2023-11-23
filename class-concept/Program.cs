namespace class_concept
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

            Employee employee1 = new Employee();
            employee1.Name = "Ehlullah";
            employee1.Surname = "Karakurt";
            employee1.No = 23415634;
            employee1.Department = "People culture";

            employee1.EmployeeInformation();

            Console.WriteLine("******************");

            Employee employee2 = new Employee();
            employee2.Name = "Deniz";
            employee2.Surname = "Arda";
            employee2.No = 25646789;
            employee2.Department = "Sales Department";

            employee2.EmployeeInformation();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee No:{0}", No);
            Console.WriteLine("Employee Department:{0}", Department);
        }
    }
}