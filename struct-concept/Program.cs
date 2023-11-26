class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        //rectangle.ShortEdge = 3;
        //rectangle.LongEdge = 4;

        Console.WriteLine("Class Calculate Area: {0}", rectangle.CalculateArea());

        Rectangle_Struct rectangle_Struct = new Rectangle_Struct(3,4);

        Console.WriteLine("Struct Calculate Area: {0}", rectangle_Struct.CalculateArea());
    }

    class Rectangle
    {
        public int ShortEdge;
        public int LongEdge;

        //public Rectangle()
        //{
        //    ShortEdge = 3;
        //    LongEdge = 4;
        //}

        public long CalculateArea()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }

    struct Rectangle_Struct
    {
        public int ShortEdge;
        public int LongEdge;

        public Rectangle_Struct(int shortEdge, int longEdge)
        {
            ShortEdge = shortEdge;
            LongEdge = longEdge;
        }

        public long CalculateArea()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
}