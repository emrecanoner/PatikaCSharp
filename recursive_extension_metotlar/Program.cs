using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - öz yinelemeli
            //3^4 = 3x3x3x3
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result*=3;
            }
            Console.WriteLine(result);

            Islemler islemler = new Islemler(); //Islemler islemler = new();
            Console.WriteLine(islemler.Expo(3,4));

            //Extension metotlar
            //Extension classlar ve metotlar static olmalı yoksa erişilemez.
            string data = "Emre Can Öner";
            Console.WriteLine(data.checkSpaces());
            if(data.checkSpaces())
            {
                Console.WriteLine(data.removeWhiteSpaces());
            }
            Console.WriteLine(data.makeUpperCase());
            Console.WriteLine(data.makeLowerCase());

            int[] arr = {8,9,1,5,4,7};
            arr.sortArray();
            arr.printArray();

            int num = 7;
            Console.WriteLine(num.isEven());

            string name ="EmreCan";
            Console.WriteLine(name.getFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int baseNum, int expNum)
        {
            if(expNum<2)
            {
                return baseNum;
            }

            return Expo(baseNum, expNum-1) * baseNum;

            //Expo(3,4)
            //Expo(3,3) * 3
            //Expo(3,2) * 3 * 3
            //Expo(3,1) * 3 * 3 * 3
            //3 * 3 * 3 * 3
        }
    }

    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }

        public static string makeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string makeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] sortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void printArray(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool isEven(this int param)
        {
            return param%2==0;
        }

        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
