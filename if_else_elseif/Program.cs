using System;

namespace if_else_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >=6 && time <11){
                Console.WriteLine("GÜnaydın");
            }
            else if(time<=18){
                Console.WriteLine("İyi günler");
            }
            else{
                Console.WriteLine("İyi geceler");
            }

            string sonuc = time<=18 ? "İyi günler" : "İyi geceler";

            sonuc = time>=6 && time<11 ? "Günaydın" : time<=18 ? "İyi günler" : "İyi geceler";
            
            Console.WriteLine(sonuc);
        }
    }
}
