using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._2
{
    public class Teacher
    {
        public string Name { get; set; }
        public bool IsCertified { get; set; }

        public Teacher() { }
        public Teacher(string name, bool iscert)
        {
            Name = name;
            IsCertified = iscert;
        }

        public string sendFeedbackToSubject(Student st)
        {
            var subj = st.getRandomSubject();
            var feedback = "";
            if (subj == "Mathematics")
            {
                var r1 = new Random();
                var r2 = new Random();
                var num1 = r1.Next(1, 50);
                var num2 = r2.Next(51, 99);

                feedback = $"{num1} + {num2} = {num1 + num2}";

            }
            else if (subj == "Chemistry")
            {
                feedback = "H20";

            }
            else if (subj == "English")
            {
                feedback = "To be not to be...";


            }
            else
            {
                feedback = $"Sorry, the {subj} is not within my competence.. ";
            }

          
                return  $"subject:{subj}; feedback: {feedback}";
            
            
            
        }
    }
    
}
