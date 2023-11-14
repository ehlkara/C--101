class Program
{
    static void Main(string[] args)
    {
        // Rekürsif - Öz yineleme
        // 3^4

        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);
        Transactions instance = new();
        Console.WriteLine(instance.Expo(3, 4));

        // Extension Methods
        string expression = "Ehlullah Karakurt";
        bool result1 = expression.CheckSpaces();
        Console.WriteLine(result1);
        if (result1)
            Console.WriteLine(expression.RemoveWhiteSpaces());
        Console.WriteLine(expression.MakeUpperCase());
        Console.WriteLine(expression.MakeLowerCase());

        int[] array = { 9, 3, 6, 2, 1, 5, 0 };
        array.SortArray();
        array.WriteConsole();

        int num = 5;
        Console.WriteLine(num.IsEvenNumber());

        Console.WriteLine(expression.GetFirstCharacter());
    }
}

public class Transactions
{
    public int Expo(int num, int pow)
    {
        if (pow < 2)
            return num;
        return Expo(num, pow - 1) * num;
    }
    // Expo(3,4)
    // Expo(3,3) * 3;
    // Expo(3,2) * 3 * 3;
    // Expo(3-1) * 3 * 3 * 3;
    // 3*3*3*3 = 3^4
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] array = param.Split(" ");
        return string.Join("*", array);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void WriteConsole(this int[] param)
    {
        foreach (var item in param)
            Console.WriteLine(item);
    }

    public static bool IsEvenNumber(this int param) {
        return param%2 == 0;
    }

    public static string GetFirstCharacter(this string param) {
        return param.Substring(0,1);
    }
}