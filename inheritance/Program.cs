using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedPlants seedPlants = new SeedPlants();
            seedPlants.propagationBySeed();

            Console.WriteLine("***** ----- *****");

            Birds birds = new Birds();
            birds.flying();
            
            
        }
    }
}
