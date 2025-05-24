namespace MusicSchoolApp
{
    public class Program
    {
        static void Main(string[] args)
        {


            string[] input = File.ReadAllLines("input.txt");
            List<SchoolMember> members = new List<SchoolMember>();
            int br = 0;
            foreach (string line in input)
            {
                br++;
                try
                {
                    var data = line.Split(";").ToList();
                    string type = data[0];
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    if (type == "Student")
                    {
                        string Instrument = data[3];
                        int practiceHours = int.Parse(data[4]);
                        SchoolMember student = new Student(name, age, Instrument, practiceHours);
                        members.Add(student);
                    }
                    else if (type == "Teacher")
                    {
                        try
                        {

                            var result = Enum.TryParse(data[3], out Speciality speciality);
                            int studentsCount = int.Parse(data[4]);
                            double salary = double.Parse(data[5]);
                            SchoolMember member = new Teacher(name, age, speciality, studentsCount, salary);
                            members.Add(member);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Specialty cannot be an empty string!");
                        }

                    }
                    else if (type == "Manager")
                    {
                        double budget = double.Parse(data[3]);
                        int yearsInService = int.Parse(data[4]);
                        SchoolMember member = new Manager(name, age, budget, yearsInService);
                        members.Add(member);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Invalid data on line {br}: {ex.Message}");
                }
            }//end foreach
            foreach (var member in members.OrderBy(x=>x.Age))
            {
                Console.WriteLine(member.Info());
                Console.WriteLine(new string('-',10));
            }
            //Инфо за учителите!
            var teacher=members.OfType<Teacher>().OrderByDescending(x=>x.StudentsCount).FirstOrDefault();
            if (teacher != null)
            {
                Console.WriteLine($"The teacher with the most students is {teacher.Name} with {teacher.StudentsCount} students");
            }

        }
    }
}
