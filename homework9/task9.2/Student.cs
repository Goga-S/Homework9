using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._2
{
    public class Student
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public DateTime Enrolement_Year { get; set; }

        
        public string getRandomSubject()
        {
            var subjects = new List<string>() { "English", "Mathematics", "Chemistry", "Geography", "Biology", "Physics", "Music", "History" };
            var rand = new Random();
            var i = rand.Next(0, 7);
            var randomSubject = subjects[i];
            return randomSubject;
        }

        public int getRemainingYears()
        {
            var currentDate = new DateTime();
            var yearsCount = currentDate.Year - Enrolement_Year.Year;

            return yearsCount;
        }
    }
}
