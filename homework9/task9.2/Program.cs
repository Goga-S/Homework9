using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st = new Student();
            var subj = st.getRandomSubject();
            //Console.WriteLine(subj);

            var tc = new Teacher();
            
            var res = tc.sendFeedbackToSubject(st);
            Console.WriteLine(res);
            
        }
    }
}
