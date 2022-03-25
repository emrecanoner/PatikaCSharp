using System;
using System.Collections;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            Console.Write("Write Sentence: ");
            string sentence = Console.ReadLine();
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            list.Add('a');
            list.Add('e');
            list.Add('ı');
            list.Add('i');
            list.Add('o');
            list.Add('ö');
            list.Add('u');
            list.Add('ü');

            for(int i =0; i<sentence.Length; i++)
            {
                if(list.Contains(sentence[i]))
                {
                    list2.Add(sentence[i]);
                }
            }

            Console.WriteLine("***** Sırasız Liste *****");
            foreach (var item in list2)
                Console.WriteLine(item);

            list2.Sort();

            Console.WriteLine("***** Sıralı Liste *****");
            foreach (var item in list2)
                Console.WriteLine(item);
        }
    }
}
