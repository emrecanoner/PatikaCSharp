using System;
using System.Collections;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama
            //toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            int num;
            int total=0,total2=0;
            int[] small = new int[3];
            int[] big = new int[3];
            ArrayList list = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Input Number(Positive) {0}: ",i+1);
                num = Convert.ToInt16(Console.ReadLine());
                list.Add(num);
            }

            list.Sort();
            Console.WriteLine("***** Sıralı Liste *****");
            foreach (var item in list)
                Console.WriteLine(item);
            
            total=Convert.ToInt16(list[0])+Convert.ToInt16(list[1])+Convert.ToInt16(list[2]);
            Console.WriteLine("***** En Küçük 3 Sayının Ortalaması");
            Console.WriteLine(total/3);

            total2=Convert.ToInt16(list[17])+Convert.ToInt16(list[18])+Convert.ToInt16(list[19]);
            Console.WriteLine("***** En Büyük 3 Sayının Ortalaması");
            Console.WriteLine(total2/3);

            Console.WriteLine("***** Toplam Ortalama *****");
            Console.WriteLine((total/3)+(total2/3));

        }
    }
}
