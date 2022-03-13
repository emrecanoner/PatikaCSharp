using System;

namespace diziler_array_sinifi_metotlari
{
    class Program
    {
        static void Main(String[] args)
        {
            //Sort
            Console.WriteLine("***** Array Sort *****");
            int[] numbers = {23,4,12,78,45,6,32,3};
            Console.WriteLine("***** Sırasız liste *****");
            foreach (var num in numbers)
                Console.WriteLine(num);

            Array.Sort(numbers);

            Console.WriteLine("***** Sıralı liste *****");
            foreach (var num in numbers)
                Console.WriteLine(num);

            //Clear
            Console.WriteLine("***** Array Clear *****");

            Array.Clear(numbers, 2, 2); //2. indeksten itibaren 2 eleman siler, yani değerini 0 yapar.

            foreach (var num in numbers)
                Console.WriteLine(num);

            //Reverse
            Console.WriteLine("***** Array Reverse *****");

            Array.Reverse(numbers);

            foreach (var num in numbers)
                Console.WriteLine(num);

            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");

            Console.WriteLine(Array.IndexOf(numbers, 23));

            //Resize
            Console.WriteLine("***** Array Resize *****");

            Array.Resize<int>(ref numbers, 9);
            numbers[8]=55;

            foreach (var num in numbers)
                Console.WriteLine(num);

        }
    }
}
