using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // access_modifier return_value method_name(parameterListes/arguement)
            //{
            ////commands
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int result = Sum(a, b);
            Console.WriteLine(result);

            Methods example = new Methods();
            example.WriteConsole(Convert.ToString(result));

            int result2 = example.PlusAndSum(ref a,ref b);
            example.WriteConsole(Convert.ToString(result2));
            example.WriteConsole(Convert.ToString(a + b));
        }

        static int Sum(int value1, int value2)
        {
            return (value1 + value2);
        }
    }

    class Methods
    {
        public void WriteConsole(string data)
        {
            Console.WriteLine(data);
        }

        public int PlusAndSum(ref int value1, ref int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
    }
}
