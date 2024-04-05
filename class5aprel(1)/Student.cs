using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5aprel_1_
{
    internal class Student
    {
        public static float Pi { get;} = 65541f;
        static Student()
        {
            Pi = 1.0f;
        }
        public void SayHi(string name)
        {
            Console.WriteLine("salam " + name);
        }

        //static class Person:Student{}
        public string Name { get; set; }
        public static void SayHi()
        {
            Console.WriteLine("ahgfdhg");
        }
    }
}
