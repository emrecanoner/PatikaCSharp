using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(days.sunday);
            Console.WriteLine((int)days.tuesday);
            Console.WriteLine((int)days.sunday);

            int weather = 20;

            if(weather<=(int)weatherCondition.cold)
                Console.WriteLine("Wait!, the weather is so cold");
            else if(weather>(int)weatherCondition.cold && weather<=(int)weatherCondition.normal)
                Console.WriteLine("Dress hard, don't be sick!");
            else if(weather>(int)weatherCondition.normal && weather<=(int)weatherCondition.warm)
                Console.WriteLine("Go fun!");
            else if(weather>(int)weatherCondition.warm && weather<=(int)weatherCondition.hot)
                Console.WriteLine("So hot, like you");
            else
                Console.WriteLine("Invalid!");
        }
    }

    enum days
    {
        monday=1,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday=23,
        sunday
    }

    enum weatherCondition
    {
        cold = 5,
        normal = 10,
        warm = 20,
        hot = 30
    }
}
