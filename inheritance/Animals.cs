namespace inheritance
{
    public class Animals : Living
	{
		protected void Adaption()
        {
            Console.WriteLine("Animals adapt.");
        }

        public override void StimuliResponse()
        {
            base.StimuliResponse();
            Console.WriteLine("Animals respond to contact.");
        }
    }

    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaption();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void CrawlingMovement()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }

    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaption();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
            base.StimuliResponse();
        }
        public void Fly()
        {
            Console.WriteLine("Birds fly.");
        }
    }
}

