using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 ile kullanıcıdan alınan sayıya kadar olan sayıların ortalamasını bul.
            Console.Write("Sayı giriniz: ");
            int num = int.Parse(Console.ReadLine());
            int counter=1, total=0;
            while(counter<=num)
            {
                total+=counter;
                counter++;
            }
            Console.WriteLine("Ortalama: "+ total/num);

            //'a' dan 'z' ye kadar tüm harfleri yazdır.
            char c = 'a';
            while (c<='z')
            {  
                Console.WriteLine(c);
                c++;    
            }

            //ForEach
            Console.WriteLine("***** ForEach *****");
            string[] cars = {"BMW", "Toyota", "Nissan", "Chevrolet"};
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
