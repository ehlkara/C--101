class Program
{
    static void Main(string[] args)
    {
        // Array definition
        string[] colors = new string[5];

        string[] animals = {"cat", "dog", "bird", "monkey"};

        int[] array;
        array = new int[5];

        // Assigning values ​​to arrays and accessing them
        colors[0] = "Blue";
        array[3] = 10;

        Console.WriteLine(animals[1]);
        Console.WriteLine(array[3]);
        Console.WriteLine(colors[0]);

        // array with loops
        // Program that calculates the average of n numbers entered from the keyboard.
        Console.Write("Please enter the number of elements of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Please enter {0}. number: ", i+1);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (var num in numArray)
            sum += num;
        
        Console.WriteLine("Average: " + sum/arrayLength);
    }
}