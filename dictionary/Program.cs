using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic namespace

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10, "Emre");
            users.Add(12, "Can");
            users.Add(13, "Öner");
            users.Add(23, "Canım");

            //Elemanlara erişim
            Console.WriteLine("***** elemanlara erişim *****");
            Console.WriteLine(users[13]);

            foreach (var item in users)
                Console.WriteLine(item);

            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(users.ContainsKey(13));
            Console.WriteLine(users.ContainsValue("Emre"));

            //Remove
            Console.WriteLine("***** Remove *****");
            users.Remove(13);
            foreach (var item in users)
                Console.WriteLine(item);

            //Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in users.Keys)
                Console.WriteLine(item);
            
            //Values
            Console.WriteLine("***** Values *****");
            foreach (var item in users.Values)
                Console.WriteLine(item);
        }
    }
}
