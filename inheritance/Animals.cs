using System;

namespace inheritance
{
    public class Animals : Creatures
    {
        protected void adaptation()
        {
            Console.WriteLine("Animals provide adaptation.");
        }
    }

    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.breathing();
            base.feeding();
            base.excretion();
            base.adaptation();
        }
        public void movingByCrawling()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }

    public class Birds : Animals
    {
        public Birds()
        {
            base.breathing();
            base.feeding();
            base.excretion();
            base.adaptation();
        }
        public void flying()
        {
            Console.WriteLine("Birds fly.");
        }

    }
}
