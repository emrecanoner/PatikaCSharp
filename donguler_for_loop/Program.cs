using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            int counter = int.Parse(Console.ReadLine());
            
            //Kullanıcıdan alınan sayıya kadar olan tek sayıları ekrana yazdır.
            for(int i =0; i<=counter; i++){
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            int odd=0,even=0;

            //1 ile 1000 arasındaki tek ve çift sayıları kendi içlerinde topla.
            for (int i = 1; i < 1000; i++)
            {
                if(i%2==0){
                    even+=i;
                }
                if(i%2==1){
                    odd+=i;
                }
            }

            Console.WriteLine("Tek toplam: "+ odd);
            Console.WriteLine("Çift toplam: "+ even);

            //break ve continue
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }

            //Sonsuz döngü
            //for (;;){}
        }
    }
}
