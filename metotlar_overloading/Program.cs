using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string num = "999";
            bool check = int.TryParse(num, out int outNum); //outNum değişkenini yukarıda da tanımlayabilirsin.
            if(check)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Sum(8,7,out int total2);
            Console.WriteLine(total2);

            //Metot aşırı yükleme - overloading
            int num2= 999;
            metotlar.Print(num2.ToString());
            metotlar.Print(num2);
            metotlar.Print("Emre ", "Can");

            //Metot imzası
            //metotAdı + parameteSayısı + parametre

        }
    }

    class Metotlar
    {
        public void Sum(int a, int b, out int total)
        {
            total=a+b;
        }

        public void Print(string data)
        {
            Console.WriteLine(data);
        }

        public void Print(int data)
        {
            Console.WriteLine(data);
        }

        public void Print(string data1, string data2)
        {
            Console.WriteLine(data1+data2);
        }
    }
}
