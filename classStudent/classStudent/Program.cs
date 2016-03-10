using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classStudent
{
    class Student
    {
        public string first_name;
        public string last_name;
        public string id;
        public int year;
        public double gpa;
        public Student(string first_name, string last_name, string id, int year, double gpa)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id = id;
            this.year = year;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return "First Name: " + this.first_name + " Last Name: " + this.last_name + " ID: "
                + this.id + " Year of study: " + this.year + " GPA: " + this.gpa;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ayan", "Kurmanbay", "15BD02093", 1, 3.99);
            Console.WriteLine(firstStudent);
            Console.ReadKey();
        }
    }
}
