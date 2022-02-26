using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** implicit conversion *****");
            //implicit conversion (bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 4;
            short c = 3;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "EmreCan";
            char f = 'o';
            string k = e + f + d;
            object g = e + f + d;
            Console.WriteLine("k: " + k);
            Console.WriteLine("g: " + g);

            //explicit conversion (bilinçli dönüşüm)
            Console.WriteLine("***** explicit conversion *****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            //tostring metodu
            Console.WriteLine("***** tostring metodu *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.3f.ToString();
            Console.WriteLine("zz: " + zz);

            //system.convert
            Console.WriteLine("***** system.convert sınıfı *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

            //parse
            Console.WriteLine("***** parse metodu *****");
            ParseMethod();
            //parse her zaman string ifadeleri dönüştürür, string alır.
        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
