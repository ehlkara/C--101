class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Saturday);

        int temperature = 32;

        if (temperature <= (int)Weather.Normal)
            Console.WriteLine("Let's wait for the weather to get a little warmer to go outside.");
        else if (temperature >= (int)Weather.Hot)
            Console.WriteLine("It's too hot a day to go out.");
        else if (temperature >= (int)Weather.Normal && temperature < (int)Weather.TooHot)
            Console.WriteLine("Let's go outside.");

    }
}

enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday = 23,
    Saturday,
    Sunday
}

enum Weather
{
    Cold = 5,
    Normal = 20,
    Hot = 25,
    TooHot = 30
}