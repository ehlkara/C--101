class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

        Employee employee = new Employee("Ayşe", "Yılmaz", "IK");
        Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);
        Employee employee1 = new Employee("Deniz", "Arda", "IK");
        Employee employee2 = new Employee("Ehlullah", "Karakurt", "IK");
        Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

        Console.WriteLine("Sum result: {0}", Transactions.Sum(100, 200));
        Console.WriteLine("Subtraction result: {0}", Transactions.Subtraction(400, 50));
    }

    class Employee
    {
        private static int employeeCount;

        public static int EmployeeCount { get => employeeCount; }

        private string Name;
        private string Surname;
        private string Department;

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++;
        }
    }

    static class Transactions
    {
        public static long Sum (int num1, int num2)
        {
            return num1 + num2;
        }

        public static long Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}