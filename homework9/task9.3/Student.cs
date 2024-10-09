using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    public class Student
    {
        public string Name {  get; set; }
        public Student() { }

        public Student(string name)
        {
            Name = name;
        }

        public virtual void Study()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am studying");
        }
        public virtual void Read()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am reading");
        }
        public virtual void Write()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am relaxing");
        }
    }
}
