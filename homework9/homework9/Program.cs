using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Goga", "Samsonia", 40, Employee.Position.developer, new List<int> { 7, 6, 10, 11, 12, 8, 0 });
            //emp.Age = 19;
            //emp.JobPosition = Employee.Position.developer;
            //emp.WorkDurationLog = new List<int> { 7, 6, 10, 11, 12, 8, 0 };

            Console.WriteLine($"name: {emp.First_Name}, age: {emp.Age}, position: {emp.JobPosition}, weeksalary: {emp.CountWeeklySalary()}");
            
        } 
    }
}
