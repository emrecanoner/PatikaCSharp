using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> -> class
            //System.Collections.Generic
            //T -> object

            List<int> numList = new List<int>();

            numList.Add(12);
            numList.Add(7);
            numList.Add(78);
            numList.Add(44);
            numList.Add(5);
            numList.Add(33);

            List<string> colorList = new List<string>();

            colorList.Add("Kırmızı");
            colorList.Add("Mavi");
            colorList.Add("Yeşil");
            colorList.Add("Turuncu");
            colorList.Add("Mor");
            colorList.Add("Siyah");

            //Count
            Console.WriteLine(numList.Count);
            Console.WriteLine(colorList.Count);

            //foreach ve List.Foreach ile listelere eişim
            foreach (var num in numList)
                Console.WriteLine(num);
            foreach (var color in colorList)
                Console.WriteLine(color);

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));
            
            //Listeden eleman silme
            numList.Remove(78);
            colorList.Remove("Siyah");

            numList.RemoveAt(0);
            colorList.RemoveAt(1);

            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            //Listede içerisinde arama
            if(numList.Contains(44))
                Console.WriteLine("44 exists");

            //Eleman ile indekse erişim
            Console.WriteLine(colorList.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme
            string[] animals = {"kedi","köpek","kuş"};
            List<string> animalList = new List<string>(animals);

            //List temizleme
            animalList.Clear();

            //List içerisinde nesne tutmak
            List<Users> users = new List<Users>();
            
            Users user1 = new Users();
            user1.Name = "Emre";
            user1.Surname = "Can";
            user1.Age = 21;

            Users user2 = new Users();
            user2.Name = "Ömer";
            user2.Surname = "Faruk";
            user2.Age = 22;

            Users user3 = new Users();
            user3.Name = "Ahmet";
            user3.Surname = "Can";
            user3.Age = 23;

            Users user4 = new Users();
            user4.Name = "Esma";
            user4.Surname = "Töre";
            user4.Age = 18;

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            List<Users> newUsers = new List<Users>();

            newUsers.Add(new Users(){
                Name="Can",
                Surname="Kal",
                Age = 14             
            });

            users.ForEach(user => Console.WriteLine("Name: "+user.Name+" Surname: " + user.Surname+" Age: " + user.Age));
            newUsers.ForEach(user => Console.WriteLine("Name: "+user.Name+" Surname: " + user.Surname+" Age: " + user.Age));

            newUsers.Clear();



            
        }
    }

    public class Users
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
