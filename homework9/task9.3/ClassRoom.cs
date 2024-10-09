using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    public class ClassRoom
    {
        public List <Student>  Students { get; set; }
        public ClassRoom() { }
        public ClassRoom(List <Student> students) 
        {
            Students = students;
        }

        public void getAllMethods() 
        {
            foreach (Student student in Students) 
            {
                student.Write();
                student.Read();
                student.Study();
                student.Relax();
            }

        }
    }
}
