using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
            Console.Write("Input Length: ");
            int length = Convert.ToInt16(Console.ReadLine());
            int[] numbers= new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Input {0}.Number: ",i+1);
                numbers[i]=Convert.ToInt16(Console.ReadLine());
            }

            foreach (var item in numbers)
            {
                if(item%2==0)
                {
                    Console.WriteLine(item);
                }
            }

            /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
            Console.Write("Input Length: ");
            int length2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input Number: ");          
            int num = Convert.ToInt16(Console.ReadLine());
            int[] numbers2= new int[length2];
            for (int i = 0; i < length2; i++)
            {
                Console.Write("Input {0}.Number: ",i+1);
                numbers2[i]=Convert.ToInt16(Console.ReadLine());
            }

            foreach (var item in numbers2)
            {
                if(item==num || num%item==0)
                {
                    Console.WriteLine(item);
                }
            }

            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
            Console.Write("Input Length: ");
            int length3 = Convert.ToInt16(Console.ReadLine());
            string[] names= new string[length3];
            for (int i = 0; i < length3; i++)
            {
                Console.Write("Input {0}.Name: ",i+1);
                names[i]= Console.ReadLine();
            }

            for (int i = length3-1; i > -1; i--)
            {
                Console.WriteLine(names[i]);
            }

            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
            Console.Write("Input Sentence: ");
            string data = Console.ReadLine();
            string[] names2 = new string[data.Length];
            int word=0,letter=0;
            for (int i = 0; i < data.Length; i++)
            { 
                if((data[i]>='a' && data[i]<='z') || (data[i]>='A' && data[i]<='Z'))
                {
                    letter++;
                }
            }

            names2 = data.Split(" ");

            foreach (var item in names2)
            {
                if(item==null)
                    break;
                word++;
            }

            Console.WriteLine("Number of Letters: "+letter);
            Console.WriteLine("number of Words: "+word);
        }
    }
}
