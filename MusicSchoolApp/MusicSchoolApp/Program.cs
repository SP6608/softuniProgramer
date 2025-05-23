namespace MusicSchoolApp
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string[] input = File.ReadAllLines("input.txt");
                foreach (string line in input) 
                {
                    Console.WriteLine(line);
                }
			}
			catch (Exception )
			{

                Console.WriteLine("Specialty cannot be an empty string!");
			}
        }
    }
}
