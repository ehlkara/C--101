namespace inheritance
{
    public class Plants : Living
	{
		protected void DoPhotosynthesis()
        {
            Console.WriteLine("Plants perform photosynthesis.");
        }

        public override void StimuliResponse()
        {
            //base.StimuliResponse();
            Console.WriteLine("Plants respond to the sun.");
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
            base.StimuliResponse();
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

