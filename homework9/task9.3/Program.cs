using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classroom = new ClassRoom(new List<Student>() { new Student("Goga Samsonia") { }, new Student("Dev Developer") { } });
            classroom.getAllMethods();
        }
    }
}
