using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Number: {0}",Employee.EmployeeNum);

            Employee employee1 = new Employee("Emre","Can","IT");
            Console.WriteLine("Employee Number: {0}",Employee.EmployeeNum);

            Employee employee2 = new Employee("Hasan","Gur","IT");
            Employee employee3 = new Employee("Murat","Ömer","IT");
            Console.WriteLine("Employee Number: {0}",Employee.EmployeeNum);

            Console.WriteLine("Toplama işleminin sonucu: {0}", ASMD.addition(55,455));
            Console.WriteLine("Çıkarma işleminin sonucu: {0}", ASMD.substraction(78,875));         

        }
    }

    class Employee
    {
        private static int employeeNum;

        public static int EmployeeNum { get => employeeNum;}

        private string name;
        private string surname;
        private string department;

        public Employee(string name, string surname, string department)
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            employeeNum++;
        }

        static Employee()
        {
            employeeNum =0;
        }

        //Employee sınıfına ilk erişildiğinde static constructor çalışır daha sonra public constructor çalışır.
        //Static classlar static metotlar, değişkenler ve propertyler içerir. Static olmayan metot, değişken ve property içermez. Kalıtım işlemi uygulanamaz.
    }

    static class ASMD
    {
        public static long addition(int x, int y)
        {
            return x+y;
        }

        public static long substraction(int x, int y)
        {
            return Math.Abs(x-y);
        }
    }
}
