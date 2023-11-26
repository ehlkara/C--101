namespace inheritance
{
    public class Plants : Living
	{
		protected void DoPhotosynthesis()
        {
            Console.WriteLine("Plants perform photosynthesis.");
        }
    }

    public class SeedyPlants : Plants
    {
        public SeedyPlants()
        {
            base.DoPhotosynthesis();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void PropagationbySeed()
        {
            Console.WriteLine("Seed plants reproduce by seeds.");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.DoPhotosynthesis();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void ReproductionThroughSports()
        {
            Console.WriteLine("Seedless plants reproduce by spores.");
        }
    }
}

