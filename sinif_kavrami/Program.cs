using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            //class sinif_adi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //  {
            //      Metot Komutları
            //  }
            //}

            //Erişim Belirleyiciler
            //Public : Her yerden erişilebilir.
            //Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            Employee employee1 = new Employee();
            employee1.name="Emre Can";
            employee1.surname="Öner";
            employee1.no=123456789;
            employee1.department="Information Technologies";
            employee1.employeeInformations();

            Console.WriteLine("*****");

            Employee employee2 = new Employee();
            employee2.name="Hasan Hüseyin";
            employee2.surname="Tayyap";
            employee2.no=987654321;
            employee2.department="Information Technologies";
            employee2.employeeInformations();
        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public void employeeInformations()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("No: {0}", no);
            Console.WriteLine("Department: {0}", department);
        }
    }
}
