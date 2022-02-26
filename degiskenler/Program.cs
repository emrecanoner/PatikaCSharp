using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;             //1 byte
            sbyte c = 8;            //1 byte

            short s = 5;            //2 byte
            ushort us = 8;          //2 byte

            Int16 i16 = 2;          // 2byte
            int i = 2;              //4 byte
            Int32 i32 = 2;          //4 byte
            Int64 i64 = 2;          //8 byte

            uint ui = 2;            //4 byte
            long l = 2;             //8 byte
            ulong ul = 2;           //8 byte

            //reel sayılar
            float f = 2;            //4 byte
            double d = 2;           //8 byte
            decimal de = 2;         //16 byte

            char ch = '2';          //2 byte
            string str = "Emre";    //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = '2';
            object o2 = "2";
            object o3 = 2;
            object o4 = 3.5;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Emre Can";
            string ad = "Emre";
            string soyad = "Can";
            string tamisim = ad+ " " +soyad;

            //integer tamlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bool1 = 10<2;

            //değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd'/'MM'/'yyyy");
            Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
