using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Dersimiz CSharp, Hoşgeldiniz!";
            string message2 = "CSharp";

            //Length
            Console.WriteLine(message.Length);

            //ToUpper, ToLower
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            //Concat
            Console.WriteLine(String.Concat(message, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(message.CompareTo(message2));
            //Aynı ise 0, 1.Değişken(message) 2.Değişkenden fazla karakter sayısına sahipse 1, tam tersi ise -1 döndürür.
            Console.WriteLine(String.Compare(message,message2,true));
            //True, büyük küçük harfe duyarsız olduğunu belirtir. False yazarsam duyarlı hale gelir.
            Console.WriteLine(String.Compare(message,message2,false));

            //Contains
            Console.WriteLine(message.Contains(message2));
            Console.WriteLine(message.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(message.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(message.IndexOf("CS")); //İlk indeksi döndürür.
            Console.WriteLine(message.IndexOf("Emre")); //-1.
            Console.WriteLine(message.LastIndexOf("i"));

            //Insert
            Console.WriteLine(message.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(message + message2.PadLeft(30)); //30 karakter boşluk ekler. (message2.Length + boşluk sayısı = 30)
            Console.WriteLine(message + message2.PadLeft(30,'*')); //30 karakter * ekler.
            Console.WriteLine(message.PadRight(32, '+') + message2);

            //Remove
            Console.WriteLine(message.Remove(10));
            Console.WriteLine(message.Remove(5,3));
            Console.WriteLine(message.Remove(0,1));

            //Replace
            Console.WriteLine(message.Replace("CSharp", "C#"));
            Console.WriteLine(message.Replace(" ", "*"));

            //Split
            Console.WriteLine(message.Split(' ')[1]);

            //Substring
            Console.WriteLine(message.Substring(4,6));

        }
    }
}
