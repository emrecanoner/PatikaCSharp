using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name="Emre Can";
            student1.Surname="Öner";
            student1.No=15987;
            student1.Grade=6;

            student1.studentInformations();

            student1.increaseGrade();
            student1.studentInformations();

            Student student2 = new Student("Hasan","Hüseyin",45678,9);
            
            student2.studentInformations();

            student2.decreaseGrade();
            student2.studentInformations();

            Student student3 = new Student("Ebru","Turan",47152,1);
            
            student3.studentInformations();

            student3.decreaseGrade();
            student3.decreaseGrade();
            student3.studentInformations();
        }
    }


    class Student
    {
        private string name;
        private string surname;
        private int no;
        private int grade;

        public string Name { get => name; set => name = value; }
        //public string name
        //{
        //  get{ return name; }
        //  set{ name = value; }
        //}
        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public int Grade { 
            get { return grade; }
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Grade can not be less than 1.");
                    grade = 1;
                }
                else
                {
                    grade = value;
                }      
            }
        }

        public Student(string name, string surname, int no, int grade)
        {
            Name = name;
            Surname = surname;
            No = no;
            Grade = grade;
        }

        public Student(){}

        public void studentInformations()
        {
            Console.WriteLine("***** Student Informations *****");
            Console.WriteLine("Name:    {0}", this.Name);
            Console.WriteLine("Surname: {0}", this.Surname);
            Console.WriteLine("No:      {0}", this.No);
            Console.WriteLine("Grade:   {0}", this.Grade);
        }

        public void increaseGrade()
        {
            this.Grade++;
        }

        public void decreaseGrade()
        {
            this.Grade--;
        }
    }
}
