using System;

namespace inheritance
{
    public class Creatures
    {
        protected void feeding()
        {
            Console.WriteLine("Creatures feed.");
        }

        protected void breathing()
        {
            Console.WriteLine("Creatures breath.");
        }

        protected void excretion()
        {
            Console.WriteLine("Creatures do excretion.");
        }
    }
}
