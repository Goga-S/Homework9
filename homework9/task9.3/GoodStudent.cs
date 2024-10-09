using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    public class GoodStudent: Student
    {
        public override void Read()
        {
            
            Console.WriteLine("I am a good student, i often read");
        }

        public override void Write()
        {

            Console.WriteLine("I am a good student, i often write");
        }

        public override void Study()
        {

            Console.WriteLine("I am a good student, i often study");
        }

        public override void Relax()
        {

            Console.WriteLine("I am a good student, i dont have much time to relax");
        }
    }
}
