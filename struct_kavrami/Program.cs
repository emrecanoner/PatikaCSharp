using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.shortSide=3;
            rectangle.longSide=4;
            Console.WriteLine("Class Alan Hesabı:  "+rectangle.calculateArea());

            Rectangle_Struct rectangle_Struct;
            rectangle_Struct.shortSide=3;
            rectangle_Struct.longSide=4;
            Console.WriteLine("Struct Alan Hesabı: "+rectangle_Struct.calculateArea());
        }
    }

    class Rectangle
    {
        public int shortSide;
        public int longSide;

        /*public Rectangle()
        {
            shortSide=3;
            longSide=4;
        } */

        public int calculateArea()
        {
            return this.shortSide*this.longSide;
        }
    }

    struct Rectangle_Struct
    {
        public int shortSide;
        public int longSide;

        public Rectangle_Struct(int shortSide, int longSide)
        {
            this.shortSide = shortSide;
            this.longSide = longSide;
        }

        /*public Rectangle_Struct() //Struct yapısı bu kullanıma izin vermiyor.
        {
            shortSide=3;
            longSide=4;
        } */
        public int calculateArea()
        {
            return this.shortSide*this.longSide;
        }
    }
}
