using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList list = new ArrayList();
            list.Add("Emre");
            list.Add(450);
            list.Add(true);
            list.Add('2');

            //İçerisindeki verilere erişim
            Console.WriteLine(list[1]);
            
            foreach (var item in list)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***** AddRange *****");
            string[] colors = {"mavi", "sarı", "turuncu"};
            List<int> numbers = new List<int>(){1,5,45,789,4,15};

            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***** Sort *****");
            ArrayList list2 = new ArrayList();
            List<int> numbers2 = new List<int>(){4,78,25,2,456,52,4};
            list2.AddRange(numbers2);
            list2.Sort();
           
            foreach (var item in list2)
                Console.WriteLine(item);

            //BinarySearch
            //Kullanmadan önce ArrayList'i sıralaman(Sort) gerekiyor.
            Console.WriteLine("***** BinarySearch *****");
            Console.WriteLine(list2.BinarySearch(78));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            list2.Reverse();
            
            foreach (var item in list2)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("***** Clear *****");
            list.Clear();
            list2.Clear();

            foreach (var item in list)
                Console.WriteLine(item);

            foreach (var item in list2)
                Console.WriteLine(item);

        }
    }
}
