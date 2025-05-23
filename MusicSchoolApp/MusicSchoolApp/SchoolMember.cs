using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolApp
{
    public abstract class SchoolMember
    {
		private string name;
		private int age;
		public abstract string Info();
        protected SchoolMember(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
		{
			get { return age; }
			set 
			{ 
				if (value <= 5)
				{
					throw new ArgumentException("Age must be greater than 5 years!");
				}
				age = value; 
			}
		}
		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name cannot be an empty string!");
				}
				name = value; 
			}
		}

	}
}
