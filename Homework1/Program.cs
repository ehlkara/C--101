class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif bir sayı girin: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{n} adet pozitif sayı girin:");
        PrintEvenNumbers(n);

        Console.WriteLine("Pozitif iki sayı girin (a, b): ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{a} adet pozitif sayı girin:");

        PrintNumbersDivisibleByM(a, b);

        Console.WriteLine("Pozitif bir sayı girin: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} adet kelime girin:");

        ReversePrintWords(x);

        Console.WriteLine("Bir cümle yazın: ");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);
        int letterCount = CountLetters(sentence);

        Console.WriteLine($"Cümledeki toplam kelime sayısı: {wordCount}");
        Console.WriteLine($"Cümledeki toplam harf sayısı: {letterCount}");
    }

    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
    //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    private static void PrintEvenNumbers(int n)
    {
        if (n <= 0)
            return;

        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine(number);
        }

        PrintEvenNumbers(n - 1);
    }

    //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    private static void PrintNumbersDivisibleByM(int n, int m)
    {
        if (n <= 0)
            return;
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % m == 0)
        {
            Console.WriteLine(number);
        }
        PrintNumbersDivisibleByM(n - 1, m);
    }

    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
    //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
    //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    private static void ReversePrintWords(int n)
    {
        if (n <= 0)
            return;
        string word = Console.ReadLine();
        ReversePrintWords(n - 1);
        Console.WriteLine(word);
    }

    //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
    //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
    private static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    private static int CountLetters(string sentence)
    {
        int letterCount = 0;
        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                letterCount++;
            }
        }
        return letterCount;
    }
}