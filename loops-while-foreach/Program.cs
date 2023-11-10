class Program
{
    static void Main(string[] args)
    {
        //while
        // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
        Console.Write("Lütfen bir sayı giriniz: ");
        int num = int.Parse(Console.ReadLine());
        int count = 1;
        int sum = 0;
        while (count <= num)
        {
            sum += count;
            count ++;
        }
        Console.WriteLine(sum/num);

        // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
        char character = 'a';
        while (character < 'z')
        {
            Console.Write(character);
            character ++;
        }

        Console.WriteLine("****** Foreach ******");
        string[] cars = {"BMV", "Ford", "Toyota", "Nissan"};

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}