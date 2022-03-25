using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            ArrayList list3 = new ArrayList();
            int num,counter;
            double total=0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Input Number(Positive) {0}: ",i+1);
                num = Convert.ToUInt16(Console.ReadLine());
                list.Add(num);
            }
            
            foreach (int item in list)
            {
                counter=0;
                for(int i =1; i<=item; i++)
                {
                    if(item%i==0){
                        counter++;
                    }
                }

                if(counter==2)
                {
                    list2.Add(item);
                }
                else
                {
                    list3.Add(item);
                }
            }

            Console.WriteLine("***** Asal Sayılar *****");
            foreach (var item in list2)
                Console.WriteLine(item);

            Console.WriteLine("***** Asal Olmayan Sayılar *****");
            foreach (var item in list3)
                Console.WriteLine(item);            

            list2.Sort();
            list3.Sort();
            
            Console.WriteLine("***** Sıralı Asal Sayılar *****");
            foreach (var item in list2)
                Console.WriteLine(item);

            Console.WriteLine("***** Sıralı Asal Olmayan Sayılar *****");
            foreach (var item in list3)
                Console.WriteLine(item);

            Console.WriteLine("***** Asal Sayıların Sayısı *****");
            Console.WriteLine(list2.Count);
            Console.WriteLine("***** Asal Olmayan Sayılar Sayısı *****");
            Console.WriteLine(list3.Count);

            foreach (int item in list2)
            {
                total+=item;
            }

            Console.WriteLine("***** Asal Sayıların Ortalaması *****");
            Console.WriteLine(Math.Round(total/list2.Count, 2));

            total=0;

            foreach (int item in list3)
            {
                total+=item;
            }

            Console.WriteLine("***** Asal Olmayan Sayıların Ortalaması *****");
            Console.WriteLine(Math.Round(total/list3.Count, 2));
        }
    }
}
