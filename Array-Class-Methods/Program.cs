class Program
{
    static void Main(string[] args)
    {
        // Sort
        int[] numArray = { 23, 12, 4, 86, 72, 3, 11, 17 };

        Console.WriteLine("***** Unsorted List *****");
        foreach (var num in numArray)
            Console.WriteLine(num);
        
        Console.WriteLine("***** Sorted List *****");
        Array.Sort(numArray);
        foreach (var num in numArray)
            Console.WriteLine(num);
        
        //Clear
        Console.WriteLine("***** Array Clear *****");
        //Using numberArray elements, it sets 0 to 2 elements starting from the 2nd index.
        Array.Clear(numArray, 2, 2);
        foreach (var num in numArray)
            Console.WriteLine(num);

        //Reverse
        Console.WriteLine("***** Array Reverse *****");
        Array.Reverse(numArray);
        foreach (var num in numArray)
            Console.WriteLine(num);
        
        //IndexOf
        Console.WriteLine("***** Array IndexOf *****");
        Console.WriteLine(Array.IndexOf(numArray, 23));

        //Resize
        Console.WriteLine("***** Array Resize *****");
        Array.Resize<int>(ref numArray, 9);
        numArray[8] = 99;
        foreach (var num in numArray)
            Console.WriteLine(num);
    }
}