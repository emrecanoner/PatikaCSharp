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

            Console.WriteLine("Employee 1");
            Employee employee1 = new Employee();
            employee1.name="Emre Can";
            employee1.surname="Öner";
            employee1.no=123456789;
            employee1.department="Information Technologies";
            employee1.employeeInformations();

            Console.WriteLine("Employee 2");
            Employee employee2 = new Employee();
            employee2.name="Hasan Hüseyin";
            employee2.surname="Tayyap";
            employee2.no=987654321;
            employee2.department="Information Technologies";
            employee2.employeeInformations();

            Console.WriteLine("Employee 3");
            Employee employee3 = new Employee("Ozan","Tufan",456123789,"Human Resources");
            employee3.employeeInformations();

            Console.WriteLine("Employee 4");
            Employee employee4 = new Employee("Cihan","Merkür");
            employee4.employeeInformations();
        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public Employee(string name, string surname, int no, string department)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.department = department;
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Employee(){}

        public void employeeInformations()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("No: {0}", no);
            Console.WriteLine("Department: {0}", department);
        }
    }
}

