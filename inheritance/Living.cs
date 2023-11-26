namespace inheritance
{
    public class Living
	{
		protected void Nutrition()
        {
            Console.WriteLine("Living things are fed.");
        }
        protected void Respiratory()
        {
            Console.WriteLine("Living things breathe.");
        }
        protected void Excretion()
        {
            Console.WriteLine("Living things excrete.");
        }

        public virtual void StimuliResponse()
        {
            Console.WriteLine("Living things respond to stimuli.");
        }
    }
}

