using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    public class LazyStudent: Student
    {

        public override void Read()
        {

            Console.WriteLine("I am a lazy student, i dont like reading");
        }

        public override void Write()
        {

            Console.WriteLine("I am a lazy student, i dont like writing");
        }

        public override void Study()
        {

            Console.WriteLine("I am a lzy student, i dont like studying");
        }

        public override void Relax()
        {

            Console.WriteLine("I am a lazy student, i like relaxing");
        }
    }
}
