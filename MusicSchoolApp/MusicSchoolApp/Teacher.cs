using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public class Teacher : SchoolMember
    {
        public Teacher(string name, int age,Speciality speciality,int studentsCount,double salary) : base(name, age)
        {
            this.Salary = salary;
            this.StudentsCount = studentsCount;
           
        }
        private Speciality specialty;
        private int studentsCount;
        private double salary;
        public double Bonus { get { return salary * studentsCount * 0.02; } }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Salary cannot be a negative number!");
                }
                salary = value;
            }
        }
        public int StudentsCount
        {
            get { return studentsCount; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Students count cannot be negative!");
                }
                studentsCount = value;
            }
        }
        public Speciality Speciailty
        {
            get { return specialty; }
            set 
            {
                specialty = value; 
            }
        }
        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Teacher: {this.Name}, Age: {this.Age} years");
            sb.AppendLine($"Specialty: {this.Speciailty}");
            sb.AppendLine($"Students count: {this.StudentsCount}");
            sb.AppendLine($"Salary: {this.Salary:f2} lv.");
            sb.AppendLine($"Bonus:{this.Bonus:f2} lv.");
            return sb.ToString().Trim();
        }
    }
    //Enumeration!
    public enum Speciality
    {
        Piano = 0,
        Violin=1,
        Guitar=2
    }

}
