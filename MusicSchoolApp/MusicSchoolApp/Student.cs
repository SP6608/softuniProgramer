using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public class Student : SchoolMember
    {
        public Student(string name, int age,string instrument,int practiceHours) : base(name, age)
        {
            this.Instrument = instrument;
            this.PracticeHours = practiceHours;
        }
        private string instrument;
        private int practiceHours;

        public int PracticeHours
        {
            get { return practiceHours; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Practice hours must be a positive number!");
                }
                practiceHours = value; 
            }
        }
        public string Instrument
        {
            get { return instrument; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Instrument cannot be an empty string!");
                }
                instrument = value;
            }
        }
        public override string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Student: {this.Name}, Age: {this.Age} years");
            sb.AppendLine($"Instrument: {this.Instrument}");
            sb.AppendLine($"Practice hours: {PracticeHours} per week");
            return sb.ToString().Trim();
        }
    }
}
