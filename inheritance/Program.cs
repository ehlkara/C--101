using inheritance;

class Program
{
    static void Main(string[] args)
    {
        //                    living
        //                      |
        //          plants               animals
        //      |           |        |            |
        //    Seedy     Seedless  reptiles      Birds

        SeedyPlants seedyPlants = new SeedyPlants();
        seedyPlants.PropagationbySeed();

        Console.WriteLine("***************");

        Birds seagull = new Birds();
        seagull.Fly();
    }
}