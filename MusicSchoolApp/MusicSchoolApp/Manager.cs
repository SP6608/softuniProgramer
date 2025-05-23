using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public class Manager : SchoolMember
    {
        public Manager(string name, int age,double budget,int yearsInService) : base(name, age)
        {
            this.Budget = budget;
            this.YearsInService = yearsInService;
        }
        private double budget;
        private int yearsInService;

        public int YearsInService
        {
            get { return yearsInService; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Years in service cannot be negative!");
                }
                yearsInService = value;
            }
        }
        public double Budget
        {
            get { return budget; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Budget must be a positive number!");
                }
                budget = value;
            }
        }
        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Manager: {Name}, Age: {Age} years");
            sb.AppendLine($"Budget: {Budget:f2} lv");
            sb.AppendLine($"Years in service: {yearsInService} years");
            return sb.ToString().Trim();
        }
    }
}
