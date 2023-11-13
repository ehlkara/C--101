class Program
{
    static void Main(string[] args)
    {
        // out parameters
        string num = "999";
        int outNum;
        bool result = int.TryParse(num, out outNum);
        if (result)
        {
            Console.WriteLine("Success!");
            Console.WriteLine(outNum);
        }
        else
        {
            Console.WriteLine("Failed!");
        }

        Methods instance = new Methods();
        instance.Sum(2,3, out int sumResult);
        Console.WriteLine(sumResult);

        // Overloading
        int expression = 999;
        instance.WriteConsole(Convert.ToString(expression));
        instance.WriteConsole(expression);
        instance.WriteConsole("Ehlullah","Karakurt");

        // Method sign
        // MethodName + parametre count + parametre
    }
}

class Methods
{
    public void Sum(int a, int b, out int sum) 
    {
        sum = a + b;
    }

    public void WriteConsole(string data) {
        Console.WriteLine(data);
    }

    public void WriteConsole(int data) {
        Console.WriteLine(data);
    }

    public void WriteConsole(string data1, string data2) {
        Console.WriteLine(data1 + data2);
    }
}