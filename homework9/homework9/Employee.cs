using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Employee
    {
        private int age;
        private string firstname;
        private string lastname;
        private Position jobposition;
        private List<int> workinghourslog;
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 16)
                {
                    this.age = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age can not be under 17!");
                    
                    //Console.WriteLine("wrong number, minimum age must be 17!!");
                }
            }
        }
        public Position JobPosition { get; set; } 
        public List<int> WorkDurationLog { get; set; }

        public Employee() { }
        

        public Employee(string FirstName, string LastName, int Age, Position jobposition, List<int> workinghourslog)
        {
            First_Name = FirstName;
            Last_Name = LastName;
            age = Age;
            JobPosition = jobposition;
            WorkDurationLog = workinghourslog;

        }

        public enum Position
        {
            manager,
            developer,
            tester
        }


        public int CountWeeklySalary()
        {
            var totalSalary = 0;
            var totalHours = 0;
            
            
            for (int i = 0; i < 7; i++)
            {
                totalHours += WorkDurationLog[i];

            }

            foreach (var item in WorkDurationLog)
            {
                var cnt = 0;
                totalSalary += countDailySalary(WorkDurationLog[cnt], JobPosition, cnt);
                cnt++;
               
            }
            if (totalHours > 50)
            {
                totalSalary = totalSalary + totalSalary / 5;
            }
            return totalSalary;
        }

        private int countDailySalary(int hourPerDay, Position position, int dayCount)
        {
        const int managerIndex = 40;
        const int developerIndex = 30;
        const int testerIndex = 20;
        const int overtimeIndex = 5;
        var salary = 0;
            if (dayCount < 5)
            {
                
                if (hourPerDay > 0 && hourPerDay <= 8)
                {
                    if (JobPosition == Position.manager) 
                    {
                        salary = hourPerDay * managerIndex;
                    } else if (JobPosition == Position.developer)
                    {
                        salary = hourPerDay * developerIndex;
                    } else
                    {
                        salary = hourPerDay * testerIndex;
                    }
                    
                }else if (hourPerDay > 8)
                {
                    if (JobPosition == Position.manager) 
                    {
                        salary = hourPerDay * managerIndex + (hourPerDay - 8) * overtimeIndex;
                    } else if (JobPosition == Position.developer)
                    {
                        salary = hourPerDay * developerIndex + (hourPerDay - 8) * overtimeIndex;
                    } else
                    {
                        salary = hourPerDay * testerIndex + (hourPerDay - 8) * overtimeIndex;
                    }
                    
                }
                
            } else
            {
                
                if (hourPerDay > 0 && hourPerDay <= 8)
                {
                    if (JobPosition == Position.manager)
                    {
                        salary = hourPerDay * managerIndex * 2;
                    }
                    else if (JobPosition == Position.developer) 
                    {
                        salary = hourPerDay * developerIndex * 2;
                    } else
                    {
                        salary = hourPerDay * testerIndex * 2;
                    }
                            
                }
                else if (hourPerDay > 8)
                {
                    if (JobPosition == Position.manager)
                    {
                        salary = (hourPerDay * managerIndex + (hourPerDay - 8) * overtimeIndex) * 2;
                    } else if (JobPosition == Position.developer)
                    {
                        salary = (hourPerDay * developerIndex + (hourPerDay - 8) * overtimeIndex) * 2;
                    } else
                    {
                        salary = (hourPerDay * testerIndex + (hourPerDay - 8) * overtimeIndex) * 2;
                    }
                        
                }
            }
            
            return salary;
        }
    }
}
