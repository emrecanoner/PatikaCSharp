using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donus_tipi metot_adı(parametre_listesi/arguman)
            //{
                ////komutlar;
            //}

            //Static class içerisinden static metotlar erişilebilir.
            //Metotlar default olarak private'dır.

            int a=2,b=4;
            Console.WriteLine(a+b);

            Console.WriteLine(Topla(a,b));

            Metotlar metotlar = new Metotlar();
            metotlar.Print(Topla(a,b).ToString());

            Console.WriteLine(metotlar.increaseAndSum(ref a,ref b));
            Console.WriteLine(a+b);  
        }

        static int Topla(int x, int y)
        {
            return x+y;
        }
    }

    class Metotlar
    {
        public void Print(string data)
        {
            Console.WriteLine(data);
        }

        public int increaseAndSum(ref int x, ref int y)
        {
            x++;
            y++;
            return x+y;
        }
    }
}
