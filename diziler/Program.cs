using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] colors = new string[8];
            string[] animals = {"Maymun", "Kuş", "Aslan", "Zürafa"};

            int[] numbers;
            numbers = new int[10];

            //Dizilere değer atama ve erişim
            Console.WriteLine(animals[1]);
            colors[0]="Mavi";
            numbers[3]= 8;
            Console.WriteLine(colors[0]);
            Console.WriteLine(numbers[3]);

            //Döngüler ile dizi kullanımı
            //Kullanıcıdan alınan n tane sayının ortalamasını bul.
            Console.Write("Dizi uzunluğu giriniz: ");
            int length = int.Parse(Console.ReadLine());
            int[] num = new int[length];
            for(int i =0; i<length; i++)
            {
                Console.Write((i+1)+". Elemanı giriniz: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            int total =0;

            for (int i = 0; i < length; i++)
            {
                total+=num[i];
            }

            Console.WriteLine("Ortalama: "+ total/length);
            total=0;

            foreach (var sayi in num)
                total+=sayi;

            Console.WriteLine("Ortalama: "+ total/length);

        }
    }
}
