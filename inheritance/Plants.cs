using System;

namespace inheritance
{
    public class Plants : Creatures
    {
        protected void photosynthesis()
        {
            Console.WriteLine("Plants do photosynthesis.");
        }
    }

    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.breathing();
            base.feeding();
            base.excretion();
            base.photosynthesis();       
        }
        public void propagationBySeed()
        {
            Console.WriteLine("Seed Plants reproduce by seed.");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.breathing();
            base.feeding();
            base.excretion();
            base.photosynthesis();  
        }
        public void propagationBySpores()
        {
            Console.WriteLine("Seedless Plants reproduce by spor.");
        }
    }
}
