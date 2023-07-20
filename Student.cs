using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    internal class Student
    {
        private int msv;
        private string name;
        private static string college = "abc";

        public Student(int msv, string name)
        {
            this.msv = msv;
            this.name = name;
        }

        public int Msv { get => msv; set => msv = value; }
        public string Nam { get => name; set => name = value; }

        public static void Change()
        {
            college = "CODEGYM";
        }

        public void Showinfo()
        {
            Console.WriteLine(msv + name + " " + college);
        }
    }
}
