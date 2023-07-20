using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student stu1 = new Student(1, "ngoc");
            Student stu2 = new Student(2, "giang");
            Student stu3 = new Student(3, "huyen");

            stu1.Showinfo();
            stu2.Showinfo();
            stu3.Showinfo();


        }
    }
}
