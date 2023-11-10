class Program
{
    static void Main(string[] args)
    {
        // Ekrandan  girilen sayıya kadar olan tek sayılarını ekrana yazdır.
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i <= count; i++)
        {
            if(i % 2 == 1){
                Console.WriteLine(i);
            }
        }

        // 1 ile 1000 arasında ki tek ve çift sayıların kendi aralarında ki toplamlarını ekrana yazdır.
        int singleSum = 0;
        int doubleSum = 0;
        for (int i = 0; i <= 1000; i++)
        {
            if(i % 2 == 1)
                singleSum += i; // singleSum = singleSum + i;
            else
                doubleSum += i;
        }

        Console.WriteLine("Single sum: " + singleSum);
        Console.WriteLine("Double sum: " + doubleSum);

        // break, continue
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                break;
            Console.WriteLine(i);
        }
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
                continue;
            Console.WriteLine(i);
        }
    }
}